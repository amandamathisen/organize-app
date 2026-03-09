using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrganizeApi.Data;
using OrganizeApi.Models;

namespace OrganizeApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TodosController : ControllerBase
{
    private readonly AppDbContext _context;

    public TodosController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IEnumerable<ToDo>> Get()
    {
        return await _context.Todos.ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<ToDo>> Create(ToDo todo)
    {
        _context.Todos.Add(todo);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(Get), new { id = todo.Id }, todo);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, ToDo updated){
        if (id != updated.Id){
            return BadRequest();
        }

        var existing = await _context.Todos.FindAsync(id);
        if (existing == null){
            return NotFound();
        }

        existing.Title = updated.Title;
        existing.IsCompleted = updated.IsCompleted;

        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id){
        var todo = await _context.Todos.FindAsync(id);

        if(todo == null){
            return NotFound();
        }

        _context.Todos.Remove(todo);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}