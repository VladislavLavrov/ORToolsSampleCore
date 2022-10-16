using Microsoft.AspNetCore.Mvc;
using ORToolsSampleCore.Models;
using System.Diagnostics;

namespace ORToolsSampleCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult DataInput()
        {
            DataInputModel _data_input = new DataInputModel();

            #region --- Задать исходные данные 

            var rawData = new List<SolverVar>();

            // Исходные данные задачи
            rawData.Add(new SolverVar { xId = 1, Koef = 2, Min = 0, Max = 10, ConstraintKoefs = new double[] { 1, 2 } });
            rawData.Add(new SolverVar { xId = 2, Koef = -3, Min = 0, Max = 100, ConstraintKoefs = new double[] { 2, 10 } });
            rawData.Add(new SolverVar { xId = 3, Koef = 4, Min = 0, Max = 20, ConstraintKoefs = new double[] { 3, -5 } });

            var rawConstraints = new List<SolverConstraint>()
            {
                new SolverConstraint { Name = "Constraint 1", Lb = double.NegativeInfinity, Ub = 900 },
                new SolverConstraint { Name = "Constraint 2", Lb = double.NegativeInfinity, Ub = 950 }
            };

            _data_input.X1_min = rawData[0].Min;
            _data_input.X1_max = rawData[0].Max;
            _data_input.X2_min = rawData[1].Min;
            _data_input.X2_max = rawData[1].Max;
            _data_input.X3_min = rawData[2].Min;
            _data_input.X3_max = rawData[2].Max;

            _data_input.ConstraintKoeff_1_X1 = rawData[0].ConstraintKoefs[0];
            _data_input.ConstraintKoeff_2_X1 = rawData[0].ConstraintKoefs[1];

            _data_input.ConstraintKoeff_1_X2 = rawData[1].ConstraintKoefs[0];
            _data_input.ConstraintKoeff_2_X2 = rawData[1].ConstraintKoefs[1];

            _data_input.ConstraintKoeff_1_X3 = rawData[2].ConstraintKoefs[0];
            _data_input.ConstraintKoeff_2_X3 = rawData[2].ConstraintKoefs[1];

            _data_input.Koeff_Z_1 = rawData[0].Koef;
            _data_input.Koeff_Z_2 = rawData[1].Koef;
            _data_input.Koeff_Z_3 = rawData[2].Koef;

            _data_input.Constraint_1_Ub = rawConstraints[0].Ub;
            _data_input.Constraint_2_Ub = rawConstraints[1].Ub;

            #endregion --- Задать исходные данные 

            ViewBag.DataInput = _data_input;

            return View();
        }

        [HttpPost]
        public IActionResult DataInput(DataInputModel DataInput)
        {
            DataOutputModel _rezult = new DataOutputModel(DataInput);

            ViewBag.Get_objective = _rezult.Get_objective;
            ViewBag.Get_opt_X1 = _rezult.Get_opt_X1;
            ViewBag.Get_opt_X2 = _rezult.Get_opt_X2;
            ViewBag.Get_opt_X3 = _rezult.Get_opt_X3;

            return View("Rezult");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}