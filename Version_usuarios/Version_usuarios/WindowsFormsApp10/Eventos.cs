﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace WindowsFormsApp10
{
    public partial class Eventos : Form
    {
        Evento evento = new Evento();


        public Eventos()
        {
           
            InitializeComponent();
        }
        
        //DATOS FIJOS PARA VISUALIZAR SOLO, HAY QUE VER COMO HACER LOS SELECT Y VOLCARLOS EN EL DATAGRID
     /*   private List<Evento> GetFutbol()
        {
            var listaFutbol = new List<Evento>();
            listaFutbol.Add(new Evento()
            {
                Id = 0001,
                Pais = "Uruguay",
                Nombre = "Campeonato Uruguayo: torneo intermedio",
                FechaInicio = "06 / 05 / 2022 14:00",
                Resultado = "Defensor 4 - 2 Danubio",
                Tipo = "futbol"
            });

            listaFutbol.Add(new Evento()
            {
                Id = 0005,
                Pais = "Argentina",
                Nombre = "Torneo Argentino",
                FechaInicio = "15 / 05 / 2022 16:00",
                Resultado = "Boca 1 - 1 River",
                Tipo = "futbol"
            });


            listaFutbol.Add(new Evento()
            {
                Id = 0002,
                Pais = "Uruguay",
                Nombre = "Campeonato Uruguayo: torneo intermedio",
                FechaInicio = "07 / 05 / 2022 14:00",
                Resultado = "Nacional 4 - 2 Plaza Colonia",
                Tipo = "futbol"
            });

            return listaFutbol;
        }
            private List<Evento> GetBasquet()
            {
                var listaBasquet = new List<Evento>();
                listaBasquet.Add(new Evento()
                {
                    Id = 0008,
                    Pais = "Uruguay",
                    Nombre = "LUB",
                    FechaInicio = "23 / 06 / 2022 22:00",
                    Resultado = "Union Atletica 89 - 78 Penarol",
                    Tipo = "Basquet"
                });

            listaBasquet.Add(new Evento()
            {
                Id = 0010,
                Pais = "Uruguay",
                Nombre = "LUB",
                FechaInicio = "25 / 06 / 2022 21:00",
                Resultado = "Aguada 89 - 78 Bigua",
                Tipo = "Basquet"
            });

            return listaBasquet;
            }

     
       */

        private void Eventos_Load(object sender, EventArgs e)
        {
            
        }

     

        private void lnkBasquet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            dataGridDeportes.DataSource = evento.Listar("basquet");

        }

        private void dataGridDeportes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lnkFutbol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { 

        dataGridDeportes.DataSource = evento.Listar("futbol");

        }



        /*
        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            Array valores = [1, 2, 3];
            if (txtPais.Text !=, null  || txtTipo.Text != null)
            {

                dataGridDeportes.DataSource = Program.listarEventos("select * from evento where Tipo='" + txtTipo.Text + "'");

            }
        }}*/
    }

      
    }

