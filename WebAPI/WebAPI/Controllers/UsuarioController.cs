using System.Collections.Generic;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Newtonsoft.Json;
using WebAPI.Models;

namespace WebAPI.Controllers
{

    [RoutePrefix("api/produto")]
    public class UsuarioController : ApiController
    {
        private static List<UsuarioModel> listaUsuarios = new List<UsuarioModel>();

        [AcceptVerbs("POST")]
        [Route("CadastrarProduto")]
        public string CadastrarProduto(UsuarioModel usuario)
        {

            listaUsuarios.Add(usuario);

            return "Produto cadastrado com sucesso!";
        }

       /* [AcceptVerbs("PUT")]
        [Route("AlterarProduto")]
        public string AlterarProduto(UsuarioModel usuario)
        {

            listaUsuarios.Where(n => n.CodProduto == usuario.CodProduto)
                         .Select(s =>
                         {
                             s.CodProduto = usuario.CodProduto;
                             s.Login = usuario.Login;
                             s.Nome = usuario.Nome;

                             return s;

                         }).ToList();



            return "Usuário alterado com sucesso!";
        }
        */
        [AcceptVerbs("DELETE")]
        [Route("ExcluirUsuario/{codproduto}")]
        public string ExcluirUsuario(int codproduto)
        {

            UsuarioModel usuario = listaUsuarios.Where(n => n.CodProduto == codproduto)
                                                .Select(n => n)
                                                .First();

            listaUsuarios.Remove(usuario);

            return "Registro excluido com sucesso!";
        }

        [AcceptVerbs("GET")]
        [Route("ConsultarPrecoPorCodigo/{codproduto}")]
        public float ConsultarPrecoPorCodigo(int codproduto)
        {

            UsuarioModel usuario = listaUsuarios.Where(n => n.CodProduto == codproduto)
                                                .Select(n => n)
                                                .FirstOrDefault();

    
            return usuario.Preco;
        }

        [AcceptVerbs("GET")]
        [Route("ConsultarProdutos")]
        public List<UsuarioModel> ConsultarProdutos()
        {
            return listaUsuarios;
        }
    }
}