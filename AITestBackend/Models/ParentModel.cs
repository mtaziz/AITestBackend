﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace AITestBackend.Models
{
    public class ParentModel : PersonModel
    {

        public string Password { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        
        #region Parent
        public static ResponseParent GetParent(string identification)
        {
            ParentModel parentModel = new ParentModel();

            using (MySqlConnection conn = ConecctionModel.conn)
            {
                conn.Open();
                string SP = AppManagement.SP_GetParent;
                MySqlCommand cmd = new MySqlCommand(SP, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@identification", identification);


                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    parentModel.identification = rdr["idCurrency"].ToString();
                    parentModel.name = rdr["Code"].ToString();
                    parentModel.lastname1 = rdr["Country"].ToString();
                    parentModel.lastname2 = rdr["Description"].ToString();
                }

                rdr.Close();

                return new ResponseParent { IsSuccessful = true, ResponseMessage = AppManagement.MSG_GetParent_Success, Parent = parentModel };
            }
        }

        public static Response RegisterParent(ParentModel parentModel)
        {
            using (MySqlConnection conn = ConecctionModel.conn)
            {
                conn.Open();

                string SP = AppManagement.SP_SaveParent;
                MySqlCommand cmd = new MySqlCommand(SP, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_user", parentModel.Identification);
                cmd.Parameters.AddWithValue("@name", parentModel.Name);
                cmd.Parameters.AddWithValue("@password", parentModel.Password);
                cmd.Parameters.AddWithValue("@phone", parentModel.Mobile);
                cmd.Parameters.AddWithValue("@parent", 1);
                cmd.Parameters.AddWithValue("@email", parentModel.Email);

                MySqlDataReader rdr = cmd.ExecuteReader();

                rdr.Close();

                if (rdr.RecordsAffected != 0)
                    return new Response { IsSuccessful = true, ResponseMessage = AppManagement.MSG_SaveParent_Success };

                return new Response { IsSuccessful = false, ResponseMessage = AppManagement.MSG_SaveParent_Failure };
            }
        }

        #endregion

        #region Login

        public static Response Login(ParentModel parent)
        {
            try
            {
                using (MySqlConnection conn = ConecctionModel.conn)
                {
                    conn.Open();
                    int idresult = 0;

                    string SP = AppManagement.SP_LoginUser;

                    MySqlCommand cmd = new MySqlCommand(SP, conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@identification", parent.identification);
                    cmd.Parameters.AddWithValue("@password", parent.password);


                    MySqlParameter NroIdInvoice = new MySqlParameter("@result", idresult);
                    NroIdInvoice.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(NroIdInvoice);

                    cmd.ExecuteNonQuery();


                    idresult = Int32.Parse(cmd.Parameters["@result"].Value.ToString());
                    if (idresult != 0)
                    {
                        if (idresult == 1)//usuario no existe
                            return new Response { IsSuccessful = false, ResponseMessage = AppManagement.MSG_Login_Failure1 };
                        if (idresult == 2)//contraseña incorrecta
                            return new Response { IsSuccessful = false, ResponseMessage = AppManagement.MSG_Login_Failure2 };
                        else
                            return new Response { IsSuccessful = false, ResponseMessage = AppManagement.MSG_Login_FailureDefault };
                    }

                    else
                        return new Response { IsSuccessful = true, ResponseMessage = AppManagement.MSG_Login_Success };
                }
            }
            catch (Exception)
            {
                return new Response { IsSuccessful = false, ResponseMessage = AppManagement.MSG_Login_FailureDefault };
            }

        }

        #endregion
    }
}
