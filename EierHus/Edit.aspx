<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="EierHus.Edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Edit</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="Return" runat="server"  CausesValidation="false" OnClick="Return_Click"
                              Text="Return"/> <br /><br />
        <asp:TextBox ID="TextBoxFornavn" runat="server"></asp:TextBox> Fornavn<br/>
            <asp:TextBox ID="TextBoxEtternavn" runat="server"></asp:TextBox> Etternavn<br/>
            <asp:TextBox ID="TextBoxTelefonnr" runat="server"></asp:TextBox> Telefonnummer<br/>
            <asp:TextBox ID="TextBoxBoligtype" runat="server"></asp:TextBox> Boligtype<br/>
            <asp:TextBox ID="TextBoxAntSov" runat="server"></asp:TextBox> Antall soverom<br/>
            <asp:TextBox ID="TextBoxAntEta" runat="server"></asp:TextBox> Atnall Etasjer<br/>
            <asp:TextBox ID="TextBoxPrimærrom" runat="server"></asp:TextBox> Primærrom<br/>
            <asp:TextBox ID="TextBoxBruksareal" runat="server"></asp:TextBox> Bruksareal<br/>
            <asp:TextBox ID="TextBoxTomteareal" runat="server"></asp:TextBox> Tomteareal<br/>
            <asp:TextBox ID="TextBoxHusfarge" runat="server"></asp:TextBox> Husfarge<br/>
            <asp:TextBox ID="TextBoxByggeår" runat="server"></asp:TextBox> Byggeår<br/>
            <asp:TextBox ID="TextBoxAdresse" runat="server"></asp:TextBox> Adresse<br/>
            <asp:TextBox ID="TextBoxPostnr" runat="server"></asp:TextBox> Postnummer<br/>
        <br />
            <asp:Button ID="Edit1" runat="server"  CausesValidation="false" OnClick="Edit_Click"
                              Text="Edit"/>

        <asp:GridView ID="GridViewInvis" runat="server" AutoGenerateColumns="False" Width="1509px" style="margin-right: 27px" ViewStateMode="Enabled" Visible="false">
            <Columns>
                <asp:BoundField ItemStyle-Width="100px" DataField="Fornavn" HeaderText="Fornavn" >
<ItemStyle Width="100px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField ItemStyle-Width="100px" DataField="Etternavn" HeaderText="Etternavn" >
<ItemStyle Width="100px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField ItemStyle-Width="100px" DataField="Telefonnr" HeaderText="Telefonnummer" >
<ItemStyle Width="100px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField ItemStyle-Width="100px" DataField="Boligtype" HeaderText="Boligtype" >
<ItemStyle Width="100px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField ItemStyle-Width="100px" DataField="AntallSoverom" HeaderText="Antall soverom" >
<ItemStyle Width="100px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField ItemStyle-Width="100px" DataField="AntallEtasjer" HeaderText="Antall etasjer" >
<ItemStyle Width="100px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField ItemStyle-Width="100px" DataField="Primærrom" HeaderText="Primærrom" >
<ItemStyle Width="100px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField ItemStyle-Width="100px" DataField="Bruksareal" HeaderText="Bruksareal" >
<ItemStyle Width="100px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField ItemStyle-Width="100px" DataField="Tomteareal" HeaderText="Tomteareal" >
<ItemStyle Width="100px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField ItemStyle-Width="100px" DataField="Farge" HeaderText="Husfarge" >
<ItemStyle Width="100px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField ItemStyle-Width="100px" DataField="Byggeår" HeaderText="Byggeår" >
<ItemStyle Width="100px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField ItemStyle-Width="100px" DataField="Adresse" HeaderText="Adresse" >
<ItemStyle Width="100px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField ItemStyle-Width="100px" DataField="Postnr" HeaderText="Postnummer" >
<ItemStyle Width="100px"></ItemStyle>
                </asp:BoundField>
            </Columns>
            </asp:GridView>
        <br />
        <asp:Label ID="Error" runat="server" Visible="false" Text="This person does not exist"></asp:Label>
    </form>
</body>
</html>
