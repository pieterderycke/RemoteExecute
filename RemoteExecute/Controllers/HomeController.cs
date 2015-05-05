using Newtonsoft.Json;
using RemoteExecute.Domain;
using RemoteExecute.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RemoteExecute.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICommandSetRepository commandRepository;

        public HomeController(ICommandSetRepository commandRepository)
        {
            this.commandRepository = commandRepository;
        }

        // GET: Home
        public ActionResult Index()
        {
            CommandSetSummaryViewModel vm = new CommandSetSummaryViewModel();
            vm.Commands = commandRepository.GetCommandSets();

            return View(vm);
        }

        public ActionResult New()
        {
            CommandEditViewModel model = new CommandEditViewModel();
            model.IsNewCommand = true;
            model.Id = null;
            model.Name = null;
            model.Commands = "undefined";

            return View("Edit", model);
        }

        public ActionResult Edit(int id)
        {
            CommandSet commandSet = commandRepository.GetCommandSet(id);

            CommandEditViewModel model = new CommandEditViewModel();
            model.IsNewCommand = false;
            model.Id = id;
            model.Name = commandSet.Name;
            model.Commands = JsonConvert.SerializeObject(commandSet.Commands);

            return View(model);
        }

        [HttpPost]
        public ActionResult Save(bool isNewCommand, int? id, string name, IEnumerable<Command> commands)
        {
            if (isNewCommand)
            {
                if (!string.IsNullOrEmpty(name))
                {
                    commandRepository.AddCommandSet(new CommandSet() { Name = name, Commands = commands });
                    return Json("Commandset created successfully.");
                }
            }
            else
            {
                commandRepository.UpdateCommandSet(id.Value, name, commands);
                return Json("Commandset updated successfully.");
            }

            return null;
        }

        [HttpPost]
        public ActionResult Execute(int id)
        {
            return null;
        }
    }
}