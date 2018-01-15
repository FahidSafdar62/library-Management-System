using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.OleDb;
using System.Data.SqlClient;


namespace library_Management_System1
{
    public partial class Profile : Form
    {
        public string constring = "Provider=SQLNCLI11;Data Source=DESKTOP-MSC16PP;Initial Catalog=lms1;User ID=sa; Password=12345678";
        public OleDbConnection con;
        public Profile()

        {
            con = new OleDbConnection(constring);
            con.Open();
            con.Close();
            fillcombogrp();
            
            InitializeComponent();
        }
         private void fillcombogrp()
        {
            try
            {
                con = new OleDbConnection(constring);
                con.Open();
                DataSet ds = new DataSet();
    }

