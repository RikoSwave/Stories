﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Stories.Server.Models;
using Stories.Server.Repositories;


namespace Stories.Server.Controllers;

[ApiController]
[Route("graph")]
public class GraphController
{
    private readonly IFamilyRepository _movieRepository;

    public GraphController(IFamilyRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }

    [HttpGet]
    public Task<D3Graph> FetchD3Graph([FromQuery] int limit)
    {
        //return _movieRepository.FetchD3Graph(limit <= 0 ? 50 : limit);

        return null;
    }
}