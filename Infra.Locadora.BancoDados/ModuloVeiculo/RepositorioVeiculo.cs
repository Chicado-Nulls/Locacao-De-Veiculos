using Locadora.Dominio.Compartilhado;
using Locadora.Dominio.ModuloCarro;
using Locadora.Dominio.ModuloVeiculo;
using Locadora.Infra.BancoDados.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Infra.BancoDados.ModuloVeiculo
{
    public class RepositorioVeiculo : RepositorioBase<Veiculo, MapeadorVeiculo>,IrepositorioVeiculo
    {
        public RepositorioVeiculo(bool BancoTeste = false) : base(BancoTeste)
        {

        }
        protected override string sqlInserir => @"Insert into [TbVeiculo]
                                                    (
                                                      Modelo,
                                                      Marca,
                                                      EnumTipoDeCombustivel,
                                                      Cor,
                                                      KmPercorrido,
                                                      CapacidadeTanque,
                                                      Placa,
                                                      GrupoDeVeiculo_Id,
                                                      FOTO
                                                    )
                                                     VALUES
                                                    (
                                                     @MODELO,
                                                     @MARCA,
                                                     @ENUMTIPODECOMBUSTIVEL,
                                                     @COR,
                                                     @KMPERCORRIDO,
                                                     @CAPACIDADETANQUE,
                                                     @PLACA,
                                                     @GRUPODEVEICULO_ID,
                                                     @FOTO
                                                    ); 
                                                       select SCOPE_IDENTITY();";


        protected override string sqlEditar => @"UPDATE [TbVeiculo]
                                                 SET
                                                   [MODELO]=@MODELO,
                                                   [MARCA]=@MARCA,
                                                   [ENUMTIPODECOMBUSTIVEL]=@ENUMTIPODECOMBUSTIVEL,
                                                   [COR]=@COR,
                                                   [KMPERCORRIDO]=@KMPERCORRIDO,
                                                   [CAPACIDADETANQUE]= @CAPACIDADETANQUE,
                                                   [PLACA]=@PLACA,
                                                   [GRUPODEVEICULO_ID]=@GRUPODEVEICULO_ID,
                                                   [FOTO]=@FOTO
                                                 WHERE 
                                                   [ID]=@ID";
        protected override string sqlExcluir => @"DELETE [TbVeiculo]
                                                      WHERE
                                                        [ID]=@ID";




        protected override string sqlSelecionarPorId =>
            @"SELECT 
                                                         
                V.ID AS VEICULO_ID,                                                         
                V.MODELO,                                                        
                V.MARCA,                                                       
                V.ENUMTIPODECOMBUSTIVEL,                                                       
                V.COR,                                                       
                V.KMPERCORRIDO,                                                        
                V.CAPACIDADETANQUE,                                                        
                V.PLACA,
                V.FOTO,

                R.Id AS GRUPODEVEICULO_ID,
                R.NOME														 
                                                          
                  FROM 
                   [TbVeiculo] AS V
                   INNER JOIN TBGRUPODEVEICULOS AS R ON V.GrupoDeVeiculo_Id=R.Id
                  WHERE
                   V.ID=@ID";





        protected override string sqlSelecionarTodos =>
            @"SELECT 
                                                         
                V.ID AS VEICULO_ID,                                                         
                V.MODELO,                                                        
                V.MARCA,                                                       
                V.ENUMTIPODECOMBUSTIVEL,                                                       
                V.COR,                                                       
                V.KMPERCORRIDO,                                                        
                V.CAPACIDADETANQUE,                                                        
                V.PLACA,
                V.FOTO,

                R.Id AS GRUPODEVEICULO_ID,
                R.NOME														 
                                                          
                FROM 
                  [TbVeiculo] AS V
                  INNER JOIN TBGRUPODEVEICULOS AS R ON V.GrupoDeVeiculo_Id=R.Id";



        protected override string sqlValidaRegistroDuplicado =>
            @"   Select 
                V.ID AS VEICULO_ID,                                                         
                V.MODELO,                                                        
                V.MARCA,                                                       
                V.ENUMTIPODECOMBUSTIVEL,                                                       
                V.COR,                                                       
                V.KMPERCORRIDO,                                                        
                V.CAPACIDADETANQUE,                                                        
                V.PLACA,

                R.Id AS GRUPODEVEICULO_ID,
                R.NOME														 
                                                          
                FROM 
                  [TbVeiculo] AS V
                  INNER JOIN TBGRUPODEVEICULOS AS R ON V.GrupoDeVeiculo_Id=R.Id
                WHERE 
                  V.PLACA=@PLACA AND V.ID <> @ID";


    }
}
