@ModelType IEnumerable(Of WebApplication1.ThongTin)
@Code
    ViewData("Title") = "Index"
End Code
<link rel="stylesheet" href="~/Content/Site.css">
<!-- Load icon library -->
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">

<div class="jumbotron">
    <h1>QUẢN LÝ THÔNG TIN BẢO HIỂM</h1>

</div>
<br />
<form class="searchForm" action="~/ThongTins/Index" method="get">
    <b>Search by: </b>
    @Html.RadioButton("searchBy", "Name", True) Name
    @Html.RadioButton("searchBy", "Category") Category
    <br />
    <br />
    @Html.TextBox("search") <button type="submit"><i class="fa fa-search" value="Search"></i></button>
</form>

<p>
    <br />
    <br />
    @Html.ActionLink("Create New", "Create")
</p>

<th>

    <Table Class="table">
        <tr>
            <th>
                @Html.DisplayNameFor(Function(model) model.Name)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.Caterogy)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.Content)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.Note)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.DateTime)
            </th>
            <th></th>
        </tr>

        @For Each item In Model
            @<tr>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.Name)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.Caterogy)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.Content)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.Note)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.DateTime)
                </td>
                <td style="background-color:aqua">
                    @Html.ActionLink("Edit", "Edit", New With {.id = item.ID}) |
                    @Html.ActionLink("Details", "Details", New With {.id = item.ID}) |
                    @Html.ActionLink("Delete", "Delete", New With {.id = item.ID})
                </td>
            </tr>
        Next

    </Table>
