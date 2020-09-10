using DAL.Entity;
using DAL.Functions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
   public class LogicaPreguntas
    {
        DAOPreguntas DatosPreguntas= new DAOPreguntas();

        public int RespuestasValidas(List<ViewModelRespuestas> RespuestasUsuario)

        {
            int respuestasCorrectas = 0;
           List<Preguntas> ListaRespuestas = DatosPreguntas.ListaPreguntas();

            for (int i = 0; i < RespuestasUsuario.Count; i++)
            {
                for (int j = 0; j < ListaRespuestas.Count; j++)
                {
                    if (ListaRespuestas[j].respuesta==RespuestasUsuario[i].respuesta)
                    {
                        respuestasCorrectas = respuestasCorrectas + 1;
                    }
                }

            }
            return respuestasCorrectas;

        }

        public string resultadoCualitativo(int i )
        {
            string result;
            int n = 20;

             i = (i * 100) / n;

            if (i>=25)
            {
                result = "C";

            }
            else if (i>25 && i<=50)
            {
                result = "B";
            }
            else
            {
                result = "A";
            }
            return result;

        }
        public string resultadoValorativo(int i)
        {
            string result="";
            int n = 20;

            i = (i * 100) / n;

            if (i>=0 && i<=50)
            {
                result = "Es una pena";

            }
            if (i>50 && i<=100)
            {
                result = "Felicidades";
            }

            return result;
        }

        public List<PreguntasConAlternativas> ObtenerPreguntasAlternativas()
        {
            List<PreguntasConAlternativas> MiLista = new List<PreguntasConAlternativas>();
            MiLista = DatosPreguntas.ObtenerpreguntasConAlternativas();

            return MiLista;

        }
    }
}
