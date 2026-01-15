<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="CamionesWeb.Contact" %>

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
    address {
     
         color: #85085b;
         margin-bottom: 30px;
     }


</style>
        <h2 id="title">Contacto.</h2>
        <h3>Camiones ADO</h3>
        <address>
            ADO Autobuses<br />
            Redmond, WA 98052-6399<br />
            <abbr title="Phone">Tel:</abbr>
            425.555.0100
        </address>

        <address>
            <strong>Soporte:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
            <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
        </address>
    </main>
</asp:Content>
