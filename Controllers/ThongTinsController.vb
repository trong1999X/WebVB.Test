Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Threading.Tasks
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports WebApplication1
Imports System.Web.Services

Namespace Controllers
    Public Class ThongTinsController
        Inherits System.Web.Mvc.Controller

        Private db As New QuanLyCTBHEntities

        ' GET: ThongTins
        Async Function Index(searchBy As String, search As String) As Task(Of ActionResult)
            If searchBy = "Category" Then
                Return View(Await db.ThongTins.Where(Function(x) x.Caterogy.Contains(search) = True OrElse search = Nothing).ToListAsync())
            Else
                Return View(Await db.ThongTins.Where(Function(y) y.Name.Contains(search) = True OrElse search = Nothing).ToListAsync())
            End If
        End Function

        ' GET: ThongTins/Details
        Async Function Details(ByVal id As Integer?) As Task(Of ActionResult)
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim thongTin As ThongTin = Await db.ThongTins.FindAsync(id)
            If IsNothing(thongTin) Then
                Return HttpNotFound()
            End If
            Return View(thongTin)
        End Function

        ' GET: ThongTins/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: ThongTins/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Async Function Create(<Bind(Include:="ID,Name,Caterogy,Content,Note,DateTime")> ByVal thongTin As ThongTin) As Task(Of ActionResult)
            If ModelState.IsValid Then
                db.ThongTins.Add(thongTin)
                Await db.SaveChangesAsync()
                Return RedirectToAction("Index")
            End If
            Return View(thongTin)
        End Function

        ' GET: ThongTins/Edit
        Async Function Edit(ByVal id As Integer?) As Task(Of ActionResult)
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim thongTin As ThongTin = Await db.ThongTins.FindAsync(id)
            If IsNothing(thongTin) Then
                Return HttpNotFound()
            End If
            Return View(thongTin)
        End Function

        ' POST: ThongTins/Edit
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Async Function Edit(<Bind(Include:="ID,Name,Caterogy,Content,Note,DateTime")> ByVal thongTin As ThongTin) As Task(Of ActionResult)
            If ModelState.IsValid Then
                db.Entry(thongTin).State = EntityState.Modified
                Await db.SaveChangesAsync()
                Return RedirectToAction("Index")
            End If
            Return View(thongTin)
        End Function

        ' GET: ThongTins/Delete
        Async Function Delete(ByVal id As Integer?) As Task(Of ActionResult)
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim thongTin As ThongTin = Await db.ThongTins.FindAsync(id)
            If IsNothing(thongTin) Then
                Return HttpNotFound()
            End If
            Return View(thongTin)
        End Function

        ' POST: ThongTins/Delete
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Async Function DeleteConfirmed(ByVal id As Integer) As Task(Of ActionResult)
            Dim thongTin As ThongTin = Await db.ThongTins.FindAsync(id)
            db.ThongTins.Remove(thongTin)
            Await db.SaveChangesAsync()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
