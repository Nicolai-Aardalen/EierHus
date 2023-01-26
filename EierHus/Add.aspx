<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="EierHus.Add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="Return" runat="server"  CausesValidation="false" OnClick="Return_Click"
                            Text="Return"/><br /><br />
            Add Eier<br />
            <asp:TextBox ID="TextBoxFornavn" runat="server"></asp:TextBox> Fornavn<br/>
            <asp:TextBox ID="TextBoxEtternavn" runat="server"></asp:TextBox> Etternavn<br/>
            <asp:TextBox ID="TextBoxTelefonnr" runat="server"></asp:TextBox> Telefonnummer<br/>
            <asp:Button ID="AddEier" runat="server"  CausesValidation="false" OnClick="AddEier_Click"
                            Text="Add"/>

            <br/><br/>
            Add Postnummer<br />
            <asp:TextBox ID="TextBoxPostNr" runat="server"></asp:TextBox> Postnummer<br/>
            <asp:TextBox ID="TextBoxPoststed" runat="server"></asp:TextBox> Poststed<br/>
            <asp:Button ID="AddPostNr" runat="server"  CausesValidation="false" OnClick="AddPostNr_Click"
                            Text="Add"/>

            <br/><br/>
            Add Hus<br />
            <asp:TextBox ID="TextBoxBoligtype" runat="server"></asp:TextBox> Boligtype<br/>
            <asp:TextBox ID="TextBoxAntSov" runat="server"></asp:TextBox> Antall Soverom<br/>
            <asp:TextBox ID="TextBoxAntEta" runat="server"></asp:TextBox> Antall Etasjer<br/>
            <asp:TextBox ID="TextBoxPrimærrom" runat="server"></asp:TextBox> Primærrom<br/>
            <asp:TextBox ID="TextBoxBruksareal" runat="server"></asp:TextBox> Bruskareal<br/>
            <asp:TextBox ID="TextBoxTomteareal" runat="server"></asp:TextBox> Tomteareal<br/>
            <asp:TextBox ID="TextBoxHusfarge" runat="server"></asp:TextBox> Husfarge<br/>
            <asp:TextBox ID="TextBoxByggeår" runat="server"></asp:TextBox> Byggeår<br/>
            <asp:TextBox ID="TextBoxAdresse" runat="server"></asp:TextBox> Adresse<br/>
            <asp:TextBox ID="TextBoxPostnummer" runat="server"></asp:TextBox> Postnummer<br/>
            <asp:Button ID="AddHus" runat="server"  CausesValidation="false" OnClick="AddHus_Click"
                            Text="Add"/>
        <br />
        <br />
        <br />
        <br />
        Tilgjengelige postnumre
        <br />
        <br />
        <asp:GridView ID="GridViewTilgjengeligePostnr" runat="server" AutoGenerateColumns="False" Width="314px" style="margin-right: 27px" ViewStateMode="Enabled">
            <AlternatingRowStyle BackColor="#CCCCCC" />
            <Columns>
                <asp:BoundField ItemStyle-Width="100px" DataField="Postnr" HeaderText="Postnummer" >
<ItemStyle Width="100px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField ItemStyle-Width="100px" DataField="Sted" HeaderText="Poststed" >
<ItemStyle Width="100px"></ItemStyle>
                </asp:BoundField>
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#808080" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>
    </form>
</body>
</html>
