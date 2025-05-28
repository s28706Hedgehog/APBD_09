using APBD_09.Data;
using APBD_09.Models;
using APBD_09.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APBD_09.Controllers;

[ApiController]
[Route("[controller]")]
public class PatientController(IClinicService clinicService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetPatientData(int patientId)
    {
        return Ok(await clinicService.GetPatientFullDataAsync(patientId));
    }
}