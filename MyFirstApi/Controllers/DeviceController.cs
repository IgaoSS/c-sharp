using Microsoft.AspNetCore.Mvc;
using MyFirstApi.Entities;

namespace MyFirstApi.Controllers;

public class DeviceController : MyFirstApiBaseController
{
    [HttpGet]
    public IActionResult Get()
    {
        //var laptop = new Laptop();

        //var model = laptop.GetModel();
        //var model = laptop.GetBrand();

        //return Ok(model);

        var key = GetRandomKey();
        return Ok(key);
    }
}