using Microsoft.EntityFrameworkCore;
using SkyFall.Model;

namespace SkyFall.Context
{
    public class HabitProvider
    {
        private readonly DatabaseContext _context;

        public HabitProvider(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<List<Habit>> GetAllHabitsAsync()
        {
            return await _context.Habits.OrderBy(habit => habit.Name).ToListAsync();
        }

        public async Task AddHabitAsync(Habit habit)
        {
            _context.Habits.Add(habit);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateHabitAsync(Habit habit)
        {
            _context.Habits.Update(habit);
            await _context.SaveChangesAsync();
        }
    }
}
