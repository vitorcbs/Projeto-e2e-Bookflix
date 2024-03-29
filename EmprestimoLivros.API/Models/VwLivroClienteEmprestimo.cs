﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EmprestimoLivros.API.Models
{
    [Keyless]
    public partial class VwLivroClienteEmprestimo
    {
        [Required]
        [Column("nomeCliente")]
        [StringLength(100)]
        [Unicode(false)]
        public string NomeCliente { get; set; }
        [Required]
        [Column("nomeLivro")]
        [StringLength(50)]
        [Unicode(false)]
        public string NomeLivro { get; set; }
        [Column("id")]
        public int Id { get; set; }
        [Column("idCliente")]
        public int IdCliente { get; set; }
        [Column("idLivro")]
        public int IdLivro { get; set; }
        [Column("dataEmprestimo", TypeName = "datetime")]
        public DateTime DataEmprestimo { get; set; }
        [Column("dataEntrega", TypeName = "datetime")]
        public DateTime DataEntrega { get; set; }
        [Column("entregue")]
        public bool Entregue { get; set; }
    }
}