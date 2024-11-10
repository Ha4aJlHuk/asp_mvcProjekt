namespace WebApplication1.Models;
using System;

public class Rental
{
 public int Id { get; set; } 
    
 public int BookId { get; set; } 
 public Book Book { get; set; } 
    
 public int UserId { get; set; } 
 public User User { get; set; } 
    
 public DateTime RentalDate { get; set; } 
    
 public DateTime DueDate { get; set; } 
    
 public DateTime? ReturnDate { get; set; } 
    
 public RentalStatus Status { get; set; } 
}

public enum RentalStatus
{
 AwaitingPickup, 
 CheckedOut, 
 Returned 
}