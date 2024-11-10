namespace WebApplication1.Models;
using System;

public class Reservation
{
    public int Id { get; set; } 
    
    public int BookId { get; set; } 
    public Book Book { get; set; } 
    
    public int UserId { get; set; } 
    public User User { get; set; } 
    
    public DateTime ReservationDate { get; set; } 
    
    public int QueuePosition { get; set; } 
}