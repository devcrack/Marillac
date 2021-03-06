﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public class C_Connection
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private string conect_String; 
        private string[] dmL;
        private string[,] tables;
        Dictionary<string, string[]> tables_s;

        public SqlConnection Con
        {
            get
            {
                return connection;
            }

            set
            {
                connection = value;
            }
        }

        public SqlDataAdapter Adapter
        {
            get
            {
                return adapter;
            }

            set
            {
                adapter = value;
            }
        }

        /// <summary>
        /// [0,0] INSERT INTO
        /// [0,1] VALUES
        /// </summary>
        public string[] DML
        {
            get
            {
                return this.dmL;
            }

            set
            {
                this.dmL = value;
            }
        }

        /// <summary>
        /// [0,0] Personas.Psicologo
        /// [0,1] Psicolo Values
        /// </summary>
        public string[,] Tables
        {
            get
            {
                return tables;
            }

            set
            {
                tables = value;
            }
        }

        public Dictionary<string, string[]> Tables_s
        {
            get
            {
                return tables_s;
            }

            set
            {
                tables_s = value;
            }
        }

        public string Conect_String
        {
            get
            {
                return conect_String;
            }

            set
            {
                conect_String = value;
            }
        }

        /// <summary>
        /// Clase para la conexion y ejecucion de Consultas en SQL
        /// </summary>
        /// <param name="c_string">Cadena de Conexion :p</param>
        public C_Connection(string c_string)
        {
            this.conect_String = c_string;
            this.connection = new SqlConnection(c_string);
            this.adapter = new SqlDataAdapter();
            this.dmL = new string[]
            {
                " INSERT INTO ",//0
                " VALUES",
                " UPDATE ",
                " SET ",//3
                " WHERE ",
                " SELECT ",
                " FROM ", //6
                " IS NULL ",
                " UNION ALL",//8
                " CONCAT",
                " IS NOT NULL ",//10
                " DELETE "
            };


            this.tables = new string[,]
            {
                { " Persona.Psicologo " }//Row = 0 Col = 0
                ,
                {"(nombre, paterno, materno, direccion, colonia, telefono, diasLaborales, sexo, limitePacientes, fechaNacimiento)" }
            };
            this.tables_s = new Dictionary<string, string[]>();
            this.tables_s.Add
                (" Persona.Psicologo", new string[] 
                  {
                      "nombre",
                      "paterno",
                      "materno",
                      "direccion",
                      "colonia",
                      "telefono",
                      "diasLaborales ",//6
                      "sexo",
                      "limitePacientes",
                      "fechaNacimiento",
                      "idPsicologo"//10
                   }
                );

            this.tables_s.Add
                (" Persona.Beneficiario", new string[]
                   {
                      " idBeneficiario ",//0
                      "idPsicologo", 
                      "nombre",
                      "paterno",//3
                      "materno",
                      "direccion",
                      "colonia", //6
                      "telefono",
                      "sexo",
                      "fechaNacimiento",
                      "edad"//10 
                   }
                );

            this.tables_s.Add
                (" Persona.Hijo", new string[]
                   {
                      " idHijo ",//0
                      "idBeneficiario",
                      "idPsicologo",
                      "nombre",//3
                      "paterno",
                      "materno",
                      "sexo",//6
                      "fechaNacimiento",
                      "edad"//8 
                   }

                );
        }

        public bool execute_Query(string query)
        {
            try
            {
                this.connection.Open();
                adapter.InsertCommand = new SqlCommand(query, this.connection);
                adapter.InsertCommand.ExecuteNonQuery();
                this.connection.Close();

                return true;
            }
            catch (Exception ex)
            {
                this.connection.Close();                
                System.Windows.Forms.MessageBox.Show(ex.Message.ToString());
            }

            return false;
        }

    }
}

