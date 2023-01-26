<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Market.aspx.cs" Inherits="EierHus.Market" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Market</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="Return" runat="server"  CausesValidation="false" OnClick="Return_Click"
                            Text="Return"/><br /><br /><br /><br />
        Hver eier uten hus <br /> <br />
        <asp:GridView ID="GridViewHusLøseEiere" runat="server" AutoGenerateColumns="False" Width="541px" style="margin-right: 27px" ViewStateMode="Enabled" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical">
            <AlternatingRowStyle BackColor="#CCCCCC" />
            <Columns>
                <asp:BoundField ItemStyle-Width="100px" DataField="ID" HeaderText="EierID" >
<ItemStyle Width="100px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField ItemStyle-Width="100px" DataField="Fornavn" HeaderText="Fornavn" >
<ItemStyle Width="100px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField ItemStyle-Width="100px" DataField="Etternavn" HeaderText="Etternavn" >
<ItemStyle Width="100px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField ItemStyle-Width="100px" DataField="Telefonnr" HeaderText="Telefonnummer" >
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
        <br />
        <br />
        <br />
        <br />
        Hvert hus til salgs <br /> <br />
        <asp:GridView ID="GridViewHusTilSalgs" runat="server" AutoGenerateColumns="False" Width="1509px" style="margin-right: 27px" ViewStateMode="Enabled" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical">
            <AlternatingRowStyle BackColor="#CCCCCC" />
            <Columns>
                <asp:BoundField ItemStyle-Width="100px" DataField="HusID" HeaderText="HusID" >
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
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        Skriv inn ID til Eier og Hus, som du vil sammenkoble i hvert sitt felt<br /><br />
        <asp:TextBox ID="TextBoxEierID" runat="server"></asp:TextBox> EierID<br /><br />
        <asp:TextBox ID="TextBoxHusID" runat="server"></asp:TextBox> HusID<br /><br />
        <asp:Button ID="Purchase" runat="server"  CausesValidation="false" OnClick="Purchase_Click"
                            Text="Purchase"/>
    </form>
</body>
</html>
