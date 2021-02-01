using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Api.Util
{
    public class Util
    {
        public string GetDescricaoEnum(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes = fi.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

            if (attributes != null && attributes.Any())
            {
                return attributes.First().Description;
            }

            return value.ToString();
        }

        public object MetodoGenerico(string classe, string metodo, Type[] tipoParametros, object[] parametros)
        {
            var assemblyFullName = System.Reflection.Assembly.GetExecutingAssembly().GetName().FullName;
            string typeString = Assembly.GetExecutingAssembly().GetName().Name + "." + classe + "," + assemblyFullName;

            //Pega a Classe da Promocao vinculada ao Produto (ex: PromocaoDoisPorUm, PromocaoTresPorDez e etc)
            Type t = Type.GetType(typeString);

            ConstructorInfo magicConstructor = t.GetConstructor(Type.EmptyTypes);

            //Pega o Metodo que CalcularDescontoPromocao, todas as promoções implementam esse método
            MethodInfo method = t.GetMethod(metodo, tipoParametros);

            //Invoca o Contrutor da Classe
            object magicClassObject = magicConstructor.Invoke(new object[] { });


            var retorno = method.Invoke(magicClassObject, parametros);

            return retorno;
        }
    }
}
