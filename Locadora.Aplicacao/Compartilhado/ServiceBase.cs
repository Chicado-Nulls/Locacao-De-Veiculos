using FluentValidation;
using FluentValidation.Results;
using Locadora.Dominio.Compartilhado;
using Locadora.Infra.BancoDados.Compartilhado;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;

namespace Locadora.Aplicacao.Compartilhado
{
    public abstract class ServiceBase<T, TValidador>
        where T : EntidadeBase<T>
         where TValidador : AbstractValidator<T>, new()
    {
        IRepositorioBase<T> repositorio;
        

        public ServiceBase(IRepositorioBase<T> repositorio)
        {
            this.repositorio = repositorio;
            
        }

        public virtual ValidationResult Inserir(T registro)
        {
            Log.Logger.Debug("Tentando inserir {Identificador}", ObterIdentificadorLog(registro));
            var validador = new TValidador();

            var resultado = validador.Validate(registro);
            if (!resultado.IsValid)
            {
                foreach (var erro in resultado.Errors)
                {
                    Log.Logger.Warning("Falha ao tentar inserir {Identificador} - {Motivo}",
                        ObterIdentificadorLog(registro), erro.ErrorMessage);
                }
                return resultado;
            }

            var existeRepetido = repositorio.ExisteRegistroIgual(registro, "Inserir");

            if (existeRepetido)
            {
                Log.Logger.Warning("Registro {Identificador} não pode ser inserido, coluna única ja cadastrada no banco!", ObterIdentificadorLog(registro));
                return GerarErroRepetido("Campos com '*' precisam ser únicos");
            }

            try
            {
                repositorio.Inserir(registro);
                Log.Logger.Warning("Registro {Identificador} inserido com sucesso!", ObterIdentificadorLog(registro));
            }catch(Exception ex)
            {
                Log.Logger.Debug("Registro {Identificador} não inserido, erro na camada Infra!", ObterIdentificadorLog(registro));
                return GerarErroRepetido("Erro na conexão, registro não inserido!");
            }
            
            return resultado;
        }

        public virtual ValidationResult Editar(T registro)
        {
            var validador = new TValidador();

            var resultado = validador.Validate(registro);

            if (!resultado.IsValid)
            {
                foreach (var erro in resultado.Errors)
                {
                    Log.Logger.Warning("Falha ao tentar editar {Identificador} - {Motivo}",
                        ObterIdentificadorLog(registro), erro.ErrorMessage);
                }
                return resultado;
            }

            var existeRepetido = repositorio.ExisteRegistroIgual(registro, "Editar");

            if (existeRepetido)
            {
                Log.Logger.Warning("Registro {Identificador} não pode ser editado, coluna única ja cadastrada no banco!", ObterIdentificadorLog(registro));
                return GerarErroRepetido("Campos com '*' precisam ser únicos");
            }

            try
            {
                repositorio.Editar(registro);
                Log.Logger.Warning("Registro {Identificador} editado com sucesso!", ObterIdentificadorLog(registro));
            }
            catch (Exception ex)
            {
                Log.Logger.Debug("Registro {Identificador} não editado, erro na camada Infra!", ObterIdentificadorLog(registro));
                return GerarErroRepetido("Erro na conexão, registro não inserido!");
            }

            return resultado;
        }

        public virtual ValidationResult Excluir(T registro)
        {
            var validador = new TValidador();

            var resultado = validador.Validate(registro);

            if (!resultado.IsValid)
            {
                foreach (var erro in resultado.Errors)
                {
                    Log.Logger.Warning("Falha ao tentar editar {Identificador} - {Motivo}",
                        ObterIdentificadorLog(registro), erro.ErrorMessage);
                }
                return resultado;
            }

            try
            {
                repositorio.Excluir(registro);
                Log.Logger.Warning("Registro {Identificador} excluído com sucesso!", ObterIdentificadorLog(registro));
            }
            catch (Exception ex)
            {
                Log.Logger.Debug("Registro {identificador} não excluído, (Descriminar o erro)", ObterIdentificadorLog(registro));
                return GerarErroRepetido("Registro possúi vinculo com outros registro e não pode ser excluído no momento!");
            }
            
            return resultado;
        }

        public virtual T SelecionarPorId(int id)
        {
            return repositorio.SelecionarPorId(id);
        }

        public virtual List<T> SelecionarTodos()
        {
            return repositorio.SelecionarTodos();
        }

        protected virtual ValidationResult GerarErroRepetido(string mensagem)
        {
            ValidationResult erro = new ValidationResult();

            erro.Errors.Add(new ValidationFailure("", mensagem));

            return erro;
        }

        protected abstract string ObterIdentificadorLog(T registro);
        
    }
}
