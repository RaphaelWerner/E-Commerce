using Api.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Api.Promocao
{
    public class Desconto
    {
        public decimal GetDesconto(Produto produto, int qtdProduto)
        {
            try
            {
                string descricao = new Util.Util().GetEnumDescription(produto.Promocao);
                var assemblyFullName = System.Reflection.Assembly.GetExecutingAssembly().GetName().FullName;
                string typeString = Assembly.GetExecutingAssembly().GetName().Name + "." + descricao + "," + assemblyFullName;

                Type t = Type.GetType(typeString);

                ConstructorInfo magicConstructor = t.GetConstructor(Type.EmptyTypes);
                MethodInfo method = t.GetMethod("CalcularDescontoPromocao", new Type[] { typeof(Produto), typeof(int) });

                object magicClassObject = magicConstructor.Invoke(new object[] { });

                return (decimal)method.Invoke(magicClassObject, new object[] { produto, qtdProduto });
            }
            catch
            {
                return 0;
            }
             
        }
    }
}
