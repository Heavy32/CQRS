﻿namespace Business.UseCases.Beer.CreateBeer
{
    public class CreateBeerCommand
    {
        public int Id {  get; set; }
        public string Name {  get; set; }
        public string Description {  get; set; }
        public float Alcohol { get; set; }
    }
}
