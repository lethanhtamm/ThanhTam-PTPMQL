using Microsoft.AspNetCore.Mvc;
namespace MyMvcApp.Controllers
{
    public class HoaDonController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult TongTien(HoaDonModel model)
        {
            // GET: /Total/
            model.ThanhTien = model.SoLuong * model.DonGia;

            // GET: /Notice/
            ViewBag.ThongBao = "Tổng tiền của đơn hàng " + model.TenHang + " là: " + model.ThanhTien;

            return View("Index");
        }
    }

    public class HoaDonModel
    {
        public int ThanhTien { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }
        public string? TenHang { get; set; }
    }
}