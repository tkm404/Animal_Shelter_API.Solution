using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using AnimalShelterApi.Models;

namespace AnimalShelterApi.DAL
{
  public class AnimalRepository : IAnimalRepository, IDisposable
  {
    private AnimalShelterApiContext context;
    public AnimalRepository(AnimalShelterApiContext context)
    {
      this.context = context;
    }
    public IEnumerable<Animal> GetAnimals(AnimalParameters animalParameters)
    {
      return FindAll()
            .OrderBy(anim => anim.Name)
            .Skip((animalParameters.PageNumber -1) * animalParameters.PageSize)
            .Take(animalParameters.PageSize)
            .ToList();

    }
  }
}