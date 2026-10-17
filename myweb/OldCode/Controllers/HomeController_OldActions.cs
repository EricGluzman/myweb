// OLD CODE - not compiled (OldCode folder is excluded in myweb.csproj).
// These were the Bids/Cars/Features actions from HomeController,
// replaced by BidsController, CarsController and FeaturesController.

        public IActionResult Bids()
        {
            var bids = _db.Bids
                          .Include(b => b.Client)   // also load the client of each bid
                          .Include(b => b.Car)      // also load the car of each bid
                          .ToList();
            return View(bids);                      // send the list to the view
        }
        public IActionResult Cars()
        {
            var cars = _db.Cars.Include(c => c.Bids).ToList();
            return View(cars);
        }   
        public IActionResult Features()
        {
            var features = _db.Features.Include(f => f.Cars).ToList();
            return View(features);
        }
