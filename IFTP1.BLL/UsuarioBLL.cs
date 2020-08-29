using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using IFTP1.DAL;
using IFTP1.EE;
using IFTP1.Interfaces;
using IFTP1.Servicios;

namespace IFTP1.BLL
{
    public class UsuarioBLL: ICrud <EEUsuario>
    {
        UsuarioDAL Crud;
        public UsuarioBLL()
        {
            Crud = new UsuarioDAL();
        }

        public bool Login(string username, string password)
        {
            if (Sesion.Instance.isLogged())
                throw new Exception("Ya hay una sesión iniciada.");

            var usuario = this.GetAll().Where(u => u.Username.Equals(username)).FirstOrDefault();

            if (usuario == null) 
                throw new Exception("Usuario inválido");

            if (!Encryptor.Hash(password).Equals(usuario.Password))
                throw new Exception("Contraseña inválida");
            else
            {
                Sesion.Instance.Login(usuario);
                return true;
            }
        }

        public void Logout()
        {
            if (!Sesion.Instance.isLogged())
                throw new Exception("No hay una sesión iniciada.");

            Sesion.Instance.Logout();
        }

        public void Delete(EEUsuario entity)
        {
            Hashtable hdata = new Hashtable();
            string query = "Usuarios_Baja";

            hdata.Add("@IdUsuario", entity.Id);
            hdata.Add("@FechaBaja", DateTime.Now);
            Crud.Escribir(query, hdata);
        }

        public IList<EEUsuario> GetAll()
        {
            List<EEUsuario> listUsuarios = new List<EEUsuario>();
            try
            {
                DataSet dataset = new DataSet();
                string query = "Usuarios_Get";

                dataset = this.Crud.Leer(query, null);
                if (dataset.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in dataset.Tables[0].Rows)
                    {
                        EEUsuario usuario = new EEUsuario();
                        usuario.Id = Convert.ToInt32(row["IdUsuario"]);
                        usuario.Username = row["Username"].ToString();
                        usuario.Password = row["Password"].ToString();
                        usuario.Nombre = row["Nombre"].ToString();
                        usuario.Apellido = row["Apellido"].ToString();
                        usuario.NumDocumento = row["NumDocumento"].ToString();
                        usuario.Telefono = row["Telefono"].ToString();
                        usuario.Domicilio = row["Domicilio"].ToString();
                        usuario.Email = row["Email"].ToString();
                        usuario.FechaAlta = Convert.ToDateTime(row["FechaAlta"]);
                        usuario.Activo = Convert.ToBoolean(row["Activo"]);
                        if (row["FechaBaja"]!= DBNull.Value) usuario.FechaBaja = Convert.ToDateTime(row["FechaBaja"]);

                        listUsuarios.Add(usuario);
                    }

                    return listUsuarios;
                } else
                {
                    return listUsuarios;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public EEUsuario GetById(int Id)
        {
            try
            {
                DataSet dataset = new DataSet();
                string query = "Usuarios_GetById";

                dataset = this.Crud.Leer(query, null);
                if (dataset.Tables[0].Rows.Count > 0)
                {
                    DataRow row = dataset.Tables[0].Rows[0];
 
                    EEUsuario usuario = new EEUsuario();
                    usuario.Username = row["Username"].ToString();
                    usuario.Password = row["Password"].ToString();
                    usuario.Nombre = row["Nombre"].ToString();
                    usuario.Apellido = row["Apellido"].ToString();
                    usuario.NumDocumento = row["NumDocumento"].ToString();
                    usuario.Telefono = row["Username"].ToString();
                    usuario.Domicilio = row["Username"].ToString();
                    usuario.Email = row["Username"].ToString();
                    usuario.FechaAlta = Convert.ToDateTime(row["FechaAlta"]);
                    usuario.Activo = Convert.ToBoolean(row["Activo"]);
                    usuario.FechaBaja = Convert.ToDateTime(row["FechaBaja"]);

                    return usuario;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void Save(EEUsuario entity)
        {
            Hashtable hdata = new Hashtable();
            string query = "Usuarios_Alta";

            if (entity.Id != 0)
            {
                query = "Usuarios_Modif";
                hdata.Add("@IdUsuario", entity.Id);
            } else
            {
                this.storeValidations(entity);
            }

            hdata.Add("@Username", entity.Username);
            hdata.Add("@Nombre", entity.Nombre);
            hdata.Add("@Password", Encryptor.Hash(entity.Password));
            hdata.Add("@Apellido", entity.Apellido);
            hdata.Add("@NumDocumento", entity.NumDocumento);
            hdata.Add("@Telefono", entity.Telefono);
            hdata.Add("@Domicilio", entity.Domicilio);
            hdata.Add("@Email", entity.Email);
            if (query == "Usuarios_Alta") hdata.Add("@FechaAlta", DateTime.Now);

            Crud.Escribir(query, hdata);
        }

        private void storeValidations(EEUsuario usuario)
        {
                var usernameExists = this.GetAll().Where(u => u.Username.Equals(usuario.Username)).FirstOrDefault();
                if (usernameExists != null)
                    throw new Exception("Ya existe un usuario con username.");

                var mailExists = this.GetAll().Where(u => u.Email.Equals(usuario.Email)).FirstOrDefault();
                if (mailExists != null)
                    throw new Exception("Ya existe un usuario con ese mail.");
        }

        private void editValidations(EEUsuario usuario)
        {
            var usernameExists = this.GetAll().Where(u => u.Username.Equals(usuario.Username)).FirstOrDefault();
            if (usernameExists != null && usernameExists.Id != usuario.Id)
                throw new Exception("Ya existe un usuario con username.");

            var mailExists = this.GetAll().Where(u => u.Email.Equals(usuario.Email)).FirstOrDefault();
            if (mailExists != null && usernameExists.Id != usuario.Id)
                throw new Exception("Ya existe un usuario con ese mail.");
        }
    }
}
