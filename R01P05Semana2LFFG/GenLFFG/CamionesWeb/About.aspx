<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="CamionesWeb.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <style>
            body {
                font-family: 'Comic Sans MS';
                margin: 0;
                padding: 0;
                /*background-image: url(C:\Users\luisf\OneDrive\Desktop\trNET\SEMANA2\R01P05Semana2LFFG\GenLFFG\CamionesWeb\img2);*/
                /*background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);*/
                height: 100vh;
                display: flex;
                justify-content: center;
                align-items: center;
                background-color: #d888fd;
            }

             h2 {
     
                 color: #85085b;
                 margin-bottom: 30px;
             }
             h3 {
     
                 color: #85085b;
                 margin-bottom: 30px;
             }
            p {
     
                 color: #85085b;
                 margin-bottom: 30px;
             }


        </style>


        <h2 id="title">Acerca del proyecto</h2>
        <h3>Programa para realizar la gestion de choferes, camiones y rutas.</h3>
        <p>En este programa se pueden realizar consultas para obtener choferes y camiones disponibles. Asi mismo crear nuevas rutas</p>
    </main>
</asp:Content>

