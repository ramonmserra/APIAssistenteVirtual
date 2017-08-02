using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class UsuarioModel
    {

        private int codproduto;
        private string produto;
        private float preco;
        private int status;
  

        public UsuarioModel()
        {
        }

        public UsuarioModel(int codproduto, string produto, float preco , int status)
        {
            this.CodProduto = codproduto;
            this.Produto = produto;
            this.Preco = preco;
            this.Status = status;
        }

        public int CodProduto        {
            get
            {
                return codproduto;
            }

            set
            {
                codproduto = value;
            }
        }

        public string Produto
        {
            get
            {
                return produto;
            }

            set
            {
                produto = value;
            }
        }

        public float Preco
        {
            get
            {
                return preco;
            }

            set
            {
                preco = value;
            }
        }

        public int Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

    }
}