using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using DeviceManagement_WebApp.Repository;
public class DeviceController : Controller
{
    private readonly IDeviceRepository _deviceRepository;
    public DeviceController(IDeviceRepository deviceRepository)
    {
        _deviceRepository = deviceRepository;
    }

    // GET: Services
    public IActionResult Index()
    {
        return View(_deviceRepository.GetAll());
    }
}
