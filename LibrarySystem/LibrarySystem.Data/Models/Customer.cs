﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LibrarySystem.Data.Models
{
    [Table("customers")]
    public partial class Customer
    {
        public Customer()
        {
            BooksCustomersLoans = new HashSet<BooksCustomersLoan>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("cpf")]
        [StringLength(14)]
        [Unicode(false)]
        public string Cpf { get; set; }
        [Required]
        [Column("name")]
        [StringLength(100)]
        [Unicode(false)]
        public string Name { get; set; }
        [Required]
        [Column("address")]
        [StringLength(100)]
        [Unicode(false)]
        public string Address { get; set; }
        [Required]
        [Column("district")]
        [StringLength(100)]
        [Unicode(false)]
        public string District { get; set; }
        [Required]
        [Column("city")]
        [StringLength(50)]
        [Unicode(false)]
        public string City { get; set; }
        [Column("phone_number")]
        [StringLength(13)]
        [Unicode(false)]
        public string PhoneNumber { get; set; }
        [Required]
        [Column("cell_number")]
        [StringLength(14)]
        [Unicode(false)]
        public string CellNumber { get; set; }
        [Required]
        [Column("email")]
        [StringLength(50)]
        [Unicode(false)]
        public string Email { get; set; }

        [InverseProperty("Customer")]
        public virtual ICollection<BooksCustomersLoan> BooksCustomersLoans { get; set; }
    }
}