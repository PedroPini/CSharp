﻿using Financas.DAO;
using Financas.Entidades;
using Financas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebMatrix.WebData;

namespace Financas.Controllers
{
    public class UsuarioController : Controller
    {
        private UsuarioDAO usuarioDAO;

        public UsuarioController(UsuarioDAO usuarioDAO)
        {
            this.usuarioDAO = usuarioDAO;
        }

        // GET: Usuario
        public ActionResult Form()
        {
            return View();
        }

        public ActionResult Adiciona(UsuarioModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    WebSecurity.CreateUserAndAccount(model.Nome, model.Senha, new { Email = model.Email });
                    //Usuario usuario = new Usuario
                    //{
                    //    Nome = model.Nome,
                    //    Email = model.Email
                    //};

                    //usuarioDAO.Adiciona(usuario);
                    //WebSecurity.CreateAccount(model.Nome, model.Senha);
                    return RedirectToAction("Index");
                }
                catch (MembershipCreateUserException e)
                {

                    ModelState.AddModelError("usuário inválido", e.Message);
                    return View("Form", model);
                }
               
            }
            else
            {
                return View("Form", model);
            }
        }

        public ActionResult Index()
        {
            IList<Usuario> usuarios = usuarioDAO.Lista();
            return View(usuarios);
        }
    }
}