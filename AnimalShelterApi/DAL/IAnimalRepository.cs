using System;
using System.Collections.Generic;
using AnimalShelterApi.Models;

namespace AnimalShelterApi.DAL
{
  public interface IAnimalRepository : IDisposable
  {
    IEnumerable<Animal> GetAnimals(AnimalParameters animalParameters);
    Animal GetAnimalByID(int animalId);
    void InsertAnimal(Animal animal);
    void DeleteAnimal(int animalId);
    void UpdateAnimal(Animal animal);
    void Save();
  }
}