using Locadora.Dominio.ModuloCarro;
using Locadora.Dominio.ModuloVeiculo;
using Locadora.Infra.BancoDados.Compartilhado;

namespace Locadora.Infra.BancoDados.ModuloVeiculo
{
    public class RepositorioVeiculo : RepositorioBase<Veiculo, MapeadorVeiculo>, IRepositorioVeiculo
    {
        protected override string sqlInserir => @"Insert into [TbVeiculo]
                                                    (
                                                      ID,
                                                      Modelo,
                                                      Marca,
                                                      EnumTipoDeCombustivel,
                                                      Cor,
                                                      KmPercorrido,
                                                      CapacidadeTanque,
                                                      Placa,
                                                      GrupoVeiculo_Id,
                                                      FOTO
                                                    )
                                                     VALUES
                                                    (
                                                     @ID,
                                                     @MODELO,
                                                     @MARCA,
                                                     @ENUMTIPODECOMBUSTIVEL,
                                                     @COR,
                                                     @KMPERCORRIDO,
                                                     @CAPACIDADETANQUE,
                                                     @PLACA,
                                                     @GRUPOVEICULO_ID,
                                                     @FOTO
                                                    ) 
                                                       ";


        protected override string sqlEditar => @"UPDATE [TbVeiculo]
                                                 SET
                                                   [MODELO]=@MODELO,
                                                   [MARCA]=@MARCA,
                                                   [ENUMTIPODECOMBUSTIVEL]=@ENUMTIPODECOMBUSTIVEL,
                                                   [COR]=@COR,
                                                   [KMPERCORRIDO]=@KMPERCORRIDO,
                                                   [CAPACIDADETANQUE]= @CAPACIDADETANQUE,
                                                   [PLACA]=@PLACA,
                                                   [GRUPOVEICULO_ID]=@GRUPOVEICULO_ID,
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

                R.Id AS GRUPOVEICULO_ID,
                R.NOME as GRUPOVEICULO_NOME														 
                                                          
                  FROM 
                   [TbVeiculo] AS V
                   INNER JOIN TBGRUPOVEICULO AS R ON V.GrupoVeiculo_Id=R.Id
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

                R.Id AS GRUPOVEICULO_ID,
                R.NOME AS GRUPOVEICULO_NOME														 
                                                          
                FROM 
                  [TbVeiculo] AS V
                  INNER JOIN TBGRUPOVEICULO AS R ON V.GrupoVeiculo_Id=R.Id";



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

                R.Id AS GRUPOVEICULO_ID,
                R.NOME														 
                                                          
                FROM 
                  [TbVeiculo] AS V
                  INNER JOIN TBGRUPOVEICULO AS R ON V.GrupoVeiculo_Id=R.Id
                WHERE 
                  V.PLACA=@PLACA AND V.ID <> @ID";


    }
}
