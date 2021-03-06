﻿using System;
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

            Type t = Type.GetType(typeString);

            ConstructorInfo magicConstructor = t.GetConstructor(Type.EmptyTypes);

            MethodInfo method = t.GetMethod(metodo, tipoParametros);

            object magicClassObject = magicConstructor.Invoke(new object[] { });

            var retorno = method.Invoke(magicClassObject, parametros);

            return retorno;
        }
    }
}
