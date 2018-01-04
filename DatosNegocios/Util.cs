﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DatosNegocios
{
    public class Util
    {
        public static string Encriptar(string texto)
        {
            try
            {

                string key = "qualityinfosolutions"; //llave para encriptar datos

                byte[] keyArray;

                byte[] Arreglo_a_Cifrar = UTF8Encoding.UTF8.GetBytes(texto);

                //Se utilizan las clases de encriptación MD5

                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();

                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));

                hashmd5.Clear();

                //Algoritmo TripleDES
                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();

                tdes.Key = keyArray;
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;

                ICryptoTransform cTransform = tdes.CreateEncryptor();

                byte[] ArrayResultado = cTransform.TransformFinalBlock(Arreglo_a_Cifrar, 0, Arreglo_a_Cifrar.Length);

                tdes.Clear();

                //se regresa el resultado en forma de una cadena
                texto = Convert.ToBase64String(ArrayResultado, 0, ArrayResultado.Length);

            }
            catch (Exception)
            {

            }
            return texto;
        }

        public static string Desencriptar(string textoEncriptado)
        {
            try
            {
                string key = "qualityinfosolutions";
                byte[] keyArray;
                byte[] Array_a_Descifrar = Convert.FromBase64String(textoEncriptado);

                //algoritmo MD5
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();

                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));

                hashmd5.Clear();

                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();

                tdes.Key = keyArray;
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;

                ICryptoTransform cTransform = tdes.CreateDecryptor();

                byte[] resultArray = cTransform.TransformFinalBlock(Array_a_Descifrar, 0, Array_a_Descifrar.Length);

                tdes.Clear();
                textoEncriptado = UTF8Encoding.UTF8.GetString(resultArray);

            }
            catch (Exception)
            {
                
            }
            return textoEncriptado;
        }

        //public static void ExportarDataGridViewExcel(List<Usuario> grd)
        //{
        //    SaveFileDialog fichero = new SaveFileDialog();
        //    fichero.Filter = "Excel (*.xls)|*.xls";
        //    if (fichero.ShowDialog() == DialogResult.OK)
        //    {
        //        Microsoft.Office.Interop.Excel.Application aplicacion;
        //        Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
        //        Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
        //        aplicacion = new Microsoft.Office.Interop.Excel.Application();
        //        libros_trabajo = aplicacion.Workbooks.Add();
        //        hoja_trabajo = (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
        //        //Recorremos el DataGridView rellenando la hoja de trabajo
        //        for (int i = 0; i < dgvUsuarios.Rows.Count - 1; i++)
        //        {
        //            for (int j = 0; j < dgvUsuarios.Columns.Count; j++)
        //            {
        //                hoja_trabajo.Cells[i + 1, j + 1] = dgvUsuarios.Rows[i].Cells[j].Value.ToString();
        //            }
        //        }
        //        libros_trabajo.SaveAs(fichero.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
        //        libros_trabajo.Close(true);
        //        aplicacion.Quit();
        //    }
        //}

        //private void FormUsuarios.ExportarDataGridViewExcel()
        //{

        //}

    }
}
