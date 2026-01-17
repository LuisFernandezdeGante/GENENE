<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BibliotecaWeb._Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Sistema de Transportes</title>
    <style>
        body {
            font-family: 'Comic Sans MS';
            margin: 0;
            padding: 0;
            /*background-image: url("img2\fondo.jpg");*/
            /*background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);*/
            height: 100vh;
            display: flex;
            justify-content: center;
            align-items: center;
            background-color: #d888fd;
        }
        
        .container {
            background-color: white;
            padding: 40px;
            border-radius: 10px;
            box-shadow: 0 10px 30px rgba(0,0,0,0.3);
            text-align: center;
            max-width: 600px;
        }
        
        h1 {
            
            color: #85085b;
            margin-bottom: 30px;
        }
        
        .menu {
            display: flex;
            flex-direction: column;
            gap: 15px;
        }
        
        .menu a {
            display: block;
            padding: 15px 30px;
            background-color: #85085b;
            color: white;
            text-decoration: none;
            border-radius: 5px;
            font-size: 18px;
            transition: background-color 0.3s;
        }
        
        .menu a:hover {
            background-color: #0056b3;
        }
        
        .icon {
            margin-right: 10px;
            font-size: 24px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>🚛 Sistema de Gestión de Transportes</h1>
            <div class="menu">
                <a href="Camiones.aspx">
                    <span class="icon">🚛</span>
                    Gestión de Camiones
                </a>
                <a href="Choferes.aspx">
                <span class="icon">👨‍✈️</span>
                Gestión de Choferes
                </a>
                <a href="Rutas.aspx">
                <span class="icon">🗺️</span>
                Gestión de Rutas
                </a>
                <a href="About.aspx">
                <span class="icon">📃</span>
                Acerca de este proyecto
                </a>
                <a href="Contact.aspx">
                <span class="icon">📞</span>
                Contactanos
                </a>
            </div>
        </div>
    </form>
</body>
</html>