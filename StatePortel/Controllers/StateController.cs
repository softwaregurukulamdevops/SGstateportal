using Microsoft.AspNetCore.Mvc;
using StatePortel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StatePortel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StateController : Controller
    {
        public readonly TrainingDBContext trainingDBContext;
        public StateController(TrainingDBContext _trainingDBContext)
        {
            trainingDBContext = _trainingDBContext;
        }
        [HttpGet("GetStateDetails")]
        public List<State> GetStateDetails()
        {
            List<State> lstState = new List<State>();
            try
            {
                lstState = trainingDBContext.State.ToList();
                return lstState;
            }
            catch (Exception ex)
            {
                lstState = new List<State>();
                return lstState;
            }
        }
        [HttpPost("AddState")]
        public string AddState(State state)
        {
            string message = string.Empty;
            try
            {
                if (!string.IsNullOrEmpty(state.StateName))
                {
                    trainingDBContext.Add(state);
                    trainingDBContext.SaveChanges();
                    message = "State added successfully";
                }
                else
                    message = "State Name required.";

            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
            return message;
        }
    }
}
