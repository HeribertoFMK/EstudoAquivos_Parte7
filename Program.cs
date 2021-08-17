using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

namespace EstudoAquivos_Parte7
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario() { Name = "Jode Andrade da Costa", Cpf = "032.323.537-97", Email = "hfmk2015@gmail.com" };
            //! a duas formas de fazer a conversão, são elas:
            StreamWriter sw = new StreamWriter(@"C:\csharp\outro.xml");
            StreamWriter sww = new StreamWriter(@"C:\csharp\outro1.xml");


            XmlSerializer serializador = new XmlSerializer(typeof(Usuario));
            XmlSerializer serializ = new XmlSerializer(usuario.GetType());

            serializador.Serialize(sw, usuario);
            serializ.Serialize(sww, usuario);



        }
    }
}
