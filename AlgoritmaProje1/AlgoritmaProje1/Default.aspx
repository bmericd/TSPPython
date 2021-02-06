<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AlgoritmaProje1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">




    

<%--              <h2>Traveling Salesman Problem Solution with Branch and Bound Technique</h2>

        <div>
            <h3>Please Select the Number of Cities</h3>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_Changed">
                <asp:ListItem Text="Number of Cities" Value=""></asp:ListItem>
                <asp:ListItem Text="1" Value="1"></asp:ListItem>
                <asp:ListItem Text="2" Value="2"></asp:ListItem>
                <asp:ListItem Text="3" Value="3"></asp:ListItem>
                <asp:ListItem Text="4" Value="4"></asp:ListItem>
                <asp:ListItem Text="5" Value="5"></asp:ListItem>
                <asp:ListItem Text="6" Value="6"></asp:ListItem>
                <asp:ListItem Text="7" Value="7"></asp:ListItem>
                <asp:ListItem Text="8" Value="8"></asp:ListItem>
                <asp:ListItem Text="9" Value="9"></asp:ListItem>
                <asp:ListItem Text="10" Value="10"></asp:ListItem>

            </asp:DropDownList>
            <br />
        </div>

        <input type="text">

        <asp:Panel ID="content" runat="server">

        </asp:Panel>--%>

        <%--    <div id="contentDiv" runat="server">

        </div>--%>


        <%-- Input from the user --%>

       <h4>Please enter the between the cities</h4>

        <h4>City1 - City2 Distance:</h4>
        <input type="text" name="c1c2" />

        <h4>City1 - City3 Distance:</h4>
        <input type="text" name="c1c3" />

        <h4>City1 - City4 Distance:</h4>
        <input type="text" name="c1c4" />

        <h4>City2 - City3 Distance:</h4>
        <input type="text" name="c2c3" />

        <h4>City2 - City4 Distance:</h4>
        <input type="text" name="c2c4" />

        <h4>City3 - City4 Distance:</h4>
        <input type="text" name="c3c4" />

        <br>
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />

        <h3>
            <asp:Label ID="distance" runat="server"></asp:Label></h3>
    


</asp:Content>


