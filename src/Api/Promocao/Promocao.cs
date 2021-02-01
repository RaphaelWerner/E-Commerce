using Api.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Api.Promocao
{
    public class Promocao
    {
        public decimal GetDesconto(Produto produto, int qtdProduto)
        {
            try
            {
                //Pega a descrição do EnumPromocao, que contém o nome da Classe da Promocao   
                string descricao = new Util.Util().GetEnumDescription(produto.Promocao);

                //Pega o nome do assembly, é necessário para o método GetType
                var assemblyFullName = System.Reflection.Assembly.GetExecutingAssembly().GetName().FullName;
                string typeString = Assembly.GetExecutingAssembly().GetName().Name + "." + descricao + "," + assemblyFullName;

                //Pega a Classe da Promocao vinculada ao Produto (ex: PromocaoDoisPorUm, PromocaoTresPorDez e etc)
                Type t = Type.GetType(typeString);
                ConstructorInfo magicConstructor = t.GetConstructor(Type.EmptyTypes);

                //Pega o Metodo que CalcularDescontoPromocao, todas as promoções implementam esse método
                MethodInfo method = t.GetMethod("CalcularDescontoPromocao", new Type[] { typeof(Produto), typeof(int) });

                //Invoca o Contrutor da Classe
                object magicClassObject = magicConstructor.Invoke(new object[] { });

                //Calcula o Desconto da Promocao
                return (decimal)method.Invoke(magicClassObject, new object[] { produto, qtdProduto });
            }
            catch
            {
                return 0;
            }
             
        }
    }
}
