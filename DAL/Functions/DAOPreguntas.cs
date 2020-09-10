using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Functions
{
   public class DAOPreguntas
    {
        Context Contexto;
        public  List<Preguntas> ListaPreguntas()
        {


            List<Preguntas> MisPreguntas = new List<Preguntas>();
           

           
            using (Contexto = new Context(("Data Source=LAPTOP-2GGF1CMS;Initial Catalog=Preguntas;Integrated Security=False;User Id=terry;Password=123;MultipleActiveResultSets=True")))
            {
               MisPreguntas= Contexto.Pregunta.ToList();
                Contexto.SaveChanges();
            }


            return MisPreguntas;


        }


        public List<PreguntasConAlternativas> ObtenerpreguntasConAlternativas()

        {
            List<PreguntasConAlternativas> viewModelsRespuestas = new List<PreguntasConAlternativas>();
            using (Contexto = new Context(("Data Source=LAPTOP-2GGF1CMS;Initial Catalog=Preguntas;Integrated Security=False;User Id=terry;Password=123;MultipleActiveResultSets=True")))
            {

                var innerjoi = (from te in Contexto.Alternativas
                                join In in Contexto.Pregunta on te.idPregunta equals In.id
                                select new
                                {

                                    enunciado = In.enunciado,
                                    alternativa1 = te.alternativa1,
                                    alternativa2 = te.alternativa2,
                                    alternativa3 = te.alternativa3,
                                    alternativa4 = te.alternativa4,
                                }).ToList();
               

                foreach (var item in innerjoi)
                {
                    viewModelsRespuestas.Add(new PreguntasConAlternativas()
                    {
                        Alternativa1 = item.alternativa1,
                        Alternativa2=item.alternativa3,
                          Alternativa3 = item.alternativa3,
                            Alternativa4 = item.alternativa4,
                            enunciado = item.enunciado,
                    }); 
                }

            }

               


            return viewModelsRespuestas;
            }

        }
    }

