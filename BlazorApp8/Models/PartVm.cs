namespace BlazorApp8.ViewModels;
public class PartVm 
{
    public int Id { get; set; }
    public string Name { get; set; }
    public CategoryVm CategoryVm { get; set; }
    public VendorVm VendorVm { get; set; }
    public string Description { get; set; }
    public string Photo { get; set; }
    public int WarrantyPeriod { get; set; }
    public bool isCurrentlyOrderable { get; set; }
  
}
