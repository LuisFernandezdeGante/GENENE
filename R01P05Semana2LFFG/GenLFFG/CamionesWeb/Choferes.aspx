


<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Choferes.aspx.cs" Inherits="ChoferesWeb.Choferes" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Gestión de Choferes</title>
    <style>
        body {
            font-family: Verdana;
            margin: 20px;
            background-color: #d888fd;
        }
        
        .container {
            max-width: 1200px;
            margin: 0 auto;
            background-color: wheat;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 2px 4px rgba(0,0,0,0.1);
        }
        
        h1 {font-family: Verdana;   
            color: #85085b;
           
            border-bottom: 3px solid #007bff;
            padding-bottom: 10px;
        }
        
        .filtros {
            margin: 20px 0;
            padding: 15px;
            background-color: #85085b;
            border-radius: 5px;
        }
        
        .filtros label {
            font-family: Verdana;
            font-weight: bold;
            color: white;
            margin-right: 10px;
        }
        
        .filtros select, .filtros input[type="button"] {
            padding: 8px 15px;
            border: 1px solid #ddd;
            border-radius: 4px;
            margin-right: 10px;
        }
        
        .filtros input[type="button"] {
            background-color: #85085b;
            color: white;
            cursor: pointer;
            border: none;
        }
        
        .filtros input[type="button"]:hover {
            background-color: #85085b;
        }
        
        .gridview {
            width: 100%;
            border-collapse: collapse;
            margin-top: 20px;
        }
        
        .gridview th {
            background-color: #e905e9;
            color: white;
            padding: 12px;
            text-align: left;
            font-weight: bold;
        }
        
        .gridview td {
            padding: 10px;
            border-bottom: 1px solid #ddd;
        }
        
        .gridview tr:hover {
            background-color: #b88baa;
        }
        
        .gridview tr {
            background-color: #f9f9f9;
        }
        
        .badge {
            padding: 5px 10px;
            border-radius: 12px;
            font-size: 12px;
            font-weight: bold;
        }
        
        .badge-success {
            background-color: #28a745;
            color: white;
        }
        
        .badge-danger {
            background-color: #dc3545;
            color: white;
        }
        
        .info-mensaje {
            padding: 15px;
            margin: 20px 0;
            border-radius: 5px;
            text-align: center;
        }
        
        .info-mensaje.info {
            background-color: #d1ecf1;
            color: #0c5460;
            border: 1px solid #f5c6cb;
        }
        
        .info-mensaje.error {
            background-color: #f8d7da;
            color: #721c24;
            border: 1px solid #f5c6cb;
        }

        .form-group {
            display: flex;
            flex-direction: column;
        }

        .form-group label {
            font-weight: bold;
            margin-bottom: 5px;
            color: #fff;
        }

        .form-row {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(250px, 1fr));
            gap: 15px;
            margin-bottom: 15px;
        }

        .container2 {
            max-width: 1200px;
            background-color: #85085b;
            
            
            
            
            

             
             margin: 0 auto;
            
             padding: 20px;
             border-radius: 8px;
             box-shadow: 0 2px 4px rgba(0,0,0,0.1);
        }

        .form-group input[type="text"],
    .form-group input[type="number"] {
            padding: 8px;
            border-radius: 4px;
            border: 1px solid #e905e9;
            background-color: #ddd;
            color: #85085b;
        }


        .btn-success {
            background-color: #1c6fec;
            color: #fff;
        }

        .btn-success:hover {
            background-color: #218838;
        }
           

        .form-actions {
            display: flex;
            gap: 10px;
            margin-top: 20px;
            flex-wrap: wrap;
        }

    </style>
</head>
<body>
    <form id="form2" runat="server">
        <div class="container">
            <h1>🚛 Gestión de Choferes</h1>
            
            <!-- Filtros -->
            <div class="filtros">
                <label>Filtrar por:</label>
                <asp:DropDownList ID="ddlFiltro" runat="server" AutoPostBack="false">
                    <asp:ListItem Value="0" Selected="True">Todos</asp:ListItem>
                    <asp:ListItem Value="1">Disponibles</asp:ListItem>
                    <asp:ListItem Value="2">No Disponibles</asp:ListItem>
                </asp:DropDownList>
                <asp:Button ID="btnFiltrar" runat="server" Text="Buscar" OnClick="btnFiltrar_Click" CssClass="btn btn-success"/>
                <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click"  CssClass="btn btn-success"/>
                <asp:Button ID="btnInicio" runat="server" Text="Inicio" OnClick="btnInicio_Click" CssClass="btn btn-success" />

                    <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" CssClass="btn btn-success"  OnClick="btnNuevo_Click"/>
                    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-success"  OnClick="btnGuardar_Click"/> <%--OnClick="btnGuardar_Click"--%>
                    <asp:Button ID="btnModificar" runat="server" Text="Modificar" CssClass="btn btn-success" OnClick="btnModificar_Click"/> <%--OnClick="btnModificar_Click"--%> 
                    <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-success" OnClick="btnEliminar_Click" OnClientClick="return confirm('¿Está seguro de eliminar este camión?');"/> <%--OnClick="btnEliminar_Click" OnClientClick="return confirm('¿Está seguro de eliminar este camión?');--%>
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-success" OnClick="btnCancelar_Click" /> <%--OnClick="btnCancelar_Click"--%>
                
             
            </div>

             <div class="container2">
                 <div class="form-row">
                     <div class="form-group">
                         <label class="required">Nombre:</label>
                         <asp:TextBox ID="txtNombre" runat="server" MaxLength="200" ></asp:TextBox>
                     </div>
                     <div class="form-group">
                         <label class="required">Apellido Paterno:</label>
                         <asp:TextBox ID="txtApPaterno" runat="server" MaxLength="200" ></asp:TextBox>
                     </div>
                     <div class="form-group">
                         <label class="required">Apellido Materno:</label>
                         <asp:TextBox ID="txtApMaterno" runat="server" MaxLength="200" ></asp:TextBox>
                     </div>
                     <div class="form-group">
                         <label class="required">Telefono:</label>
                         <asp:TextBox ID="txtTelefono" runat="server" MaxLength="10" ></asp:TextBox>
                     </div>
                     <div class="form-group">
                         <label class="required">Licencia:</label>
                         <asp:TextBox ID="txtLicencia" runat="server" MaxLength="10" ></asp:TextBox>
                     </div>
                     <div class="form-group">
                         <label class="required">URL de la Foto:</label>
                         <asp:TextBox ID="txtUrlFoto" runat="server" MaxLength="200" ></asp:TextBox>
                     </div>
                     <div class="form-group">
                         <label style="margin-bottom: 5px;">Disponible:</label>
                         <asp:CheckBox ID="chkDisponibilidad" runat="server"  Checked="true" />
                     </div>

                     
                     <div class="form-group">
                         <label class="required">Fecha de Nacimiento:</label>
                         <asp:TextBox ID="txtFechaNacimiento" runat="server" TextMode="Date"></asp:TextBox>
                     </div>
                     
                  </div>
             </div>
            
            <!-- Mensaje de información -->
            <asp:Panel ID="pnlMensaje" runat="server" Visible="false" CssClass="info-mensaje">
                <asp:Label ID="lblMensaje" runat="server"></asp:Label>
            </asp:Panel>
            
            <!-- GridView de Chofer -->
            <asp:GridView ID="gvChofer" runat="server" 
                          CssClass="gridview" 
                          AutoGenerateColumns="False"
                          EmptyDataText="No se encontraron choferes registrados"
                          GridLines="None"
                          OnRowCommand="gvChoferes_RowCommand">
                <Columns>
                    <asp:ButtonField ButtonType="Button" CommandName="Seleccionar" Text="Seleccionar" HeaderText="." />
                    <asp:BoundField DataField="IdChofer" HeaderText="ID" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="ApPaterno" HeaderText="Paterno" />
                    <asp:BoundField DataField="ApMaterno" HeaderText="Materno" />
                    <asp:BoundField DataField="Telefono" HeaderText="Telefono" />
                    <%--<asp:BoundField DataField="Capacidad" HeaderText="Capacidad (kg)" />--%> <%--DataFormatString="{0:N0}--%>
                    <asp:BoundField DataField="Licencia" HeaderText="Licencia" /> <%--DataFormatString="{0:N2}--%>
                    <asp:TemplateField HeaderText="Estado">
                        <ItemTemplate>
                            <span class='badge <%# (bool)Eval("Disponibilidad") ? "badge-success" : "badge-danger" %>'>
                                <%# (bool)Eval("Disponibilidad") ? "Disponible" : "No Disponible" %>
                            </span>
                        </ItemTemplate>
                    </asp:TemplateField>
                    
                </Columns>
            </asp:GridView>
        </div>

       <%-- <div class="container2">
            <div class="form-row">
                <div class="form-group">
                    <label class="required">Nombre:</label>
                    <asp:TextBox ID="txtNombre" runat="server" MaxLength="200" ></asp:TextBox>
                </div>
                <div class="form-group">
                    <label class="required">Apellido Paterno:</label>
                    <asp:TextBox ID="txtApPaterno" runat="server" MaxLength="200" ></asp:TextBox>
                </div>
                <div class="form-group">
                    <label class="required">Apellido Materno:</label>
                    <asp:TextBox ID="txtApMaterno" runat="server" MaxLength="200" ></asp:TextBox>
                </div>

             </div>
        </div>--%>


    </form>
</body>
</html>