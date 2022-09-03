#include <iomanip>
#include <iostream>
using std::cin;
using std::cout;

int main() {
  // TODO: Create a program that computes the restaurant bill.
  const float mealTax = .075;
  float totalAmount, taxAmount, tipAmount, combinedTotal, tipPercent, mealCost;

  std::cout << "Please input meal cost: ";
  std::cin >> mealCost;

  std::cout << "Please input tip percentage: ";
  std::cin >> tipPercent;

  taxAmount = mealCost * mealTax;
  tipAmount = mealCost * (tipPercent / 100);
  combinedTotal = taxAmount + tipAmount + mealCost;

  
  std::cout << std::fixed << std::setprecision(2);
  std::cout << "\nRestaurant Bill";
  std::cout << "\n====================";
  std::cout << "\nSubtotal: $" << mealCost;
  std::cout << "\nTaxes: $" << taxAmount;
  std::cout << "\nTip: $" << tipAmount;
  std::cout << "\n====================";
  std::cout << "\nTotal: $" << combinedTotal << "\n";



  return 0;
}
