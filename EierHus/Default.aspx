<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EierHus.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>EierHus</title>
</head>
<body>
    <form id="form1" runat="server">
            <asp:TextBox ID="TextBoxPostnr" runat="server"></asp:TextBox>
            <asp:Button ID="PostnrSøk" runat="server" Text="Søk på postnummer" OnClick="PostnrSøk_Click" Width="145px" />
            <br />
            <br/>
            <asp:TextBox ID="TextBoxTLFnr" runat="server"></asp:TextBox>
            <asp:Button ID="TLFnrSøk" runat="server" Text="Søk på telefonnummer" OnClick="TLFnrSøk_Click" Width="145px" />
            <br />
            <br/>
            <asp:TextBox ID="TextBoxBoligtype" runat="server"></asp:TextBox>
            <asp:Button ID="BoligtypeSøk" runat="server" Text="Søk på boligtype" OnClick="BoligtypeSøk_Click" Width="145px" />
            <br />
            <br />
             <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" AllowPaging="True" PageSize="10" Width="1509px" style="margin-right: 27px" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" ViewStateMode="Enabled">
                <AlternatingRowStyle BackColor="#CCCCCC" />
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
                <asp:BoundField ItemStyle-Width="100px" DataField="Sted" HeaderText="Poststed" >
<ItemStyle Width="100px"></ItemStyle>
                </asp:BoundField>
                <asp:TemplateField ShowHeader="False">
                    <ItemTemplate>
                        <asp:Button ID="Edit" runat="server"  CausesValidation="false" OnClick="Edit_Click" CommandArgument='<%# Eval("ID") %>'
                            Text="Edit"/>
                        <asp:Button ID="Delete" runat="server"  CausesValidation="false" OnClick="Delete_Click" CommandArgument='<%# Eval("ID") %>'
                            Text="Delete"/>
                    </ItemTemplate>
                </asp:TemplateField>
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
        <asp:Button ID="Add" runat="server"  CausesValidation="false" OnClick="Add_Click"
                            Text="Add"/>
        <asp:Button ID="Market" runat="server"  CausesValidation="false" OnClick="Market_Click"
                            Text="Market"/>
    </form>
</body>
</html>
