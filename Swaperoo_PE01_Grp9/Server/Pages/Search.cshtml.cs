

@page "Search"
@model SearchModel

@{
    ViewData["Title"] = "Home page";
}


< form method = "post" class= "searchForm" >
    <input type="text" name="searchString" />
    <input type="submit" value="Search" />
</ form >


@foreach(var product in Model.Products)
{
    < p > @product.Headline </ p >
    < p > @product.Text </ p >
    < br />
    < br />
    < br />
}