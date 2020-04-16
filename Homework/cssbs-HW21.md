# C# Homework 21
#### --AJ McCray

1. LINQ is a .NET Framework component which adds NATIVE data querying capabilities while SQL is a stand-alone RDMS language

2. The datastructure must implement the IEnumerable<T> interface (the data types must be enumerable)

3. Select is an extension method of the IEnumerable<T> class

4. [IEnumerable<string>] = declares the type as an enumerable interface; [customerFirstNames] = object name; [customers.Select(cust => cust.FirstName)] = accesses the customer database and "selects" each row 1 at a time and establishes a return value of first name to be enumerated through;

5. IEnumerable<string> usCompanies = addresses.Where(addr =>String.Equals(addr.Country, "United States")).Select(usComp => usComp.CompanyName);

6. IEnumerable<string> companyNames = addresses.OrderBy(addr =>addr.CompanyName).Select(comp => comp.CompanyName);

7. var companiesGroupedByCountry = addresses.GroupBy(addrs => addrs.Country);

8. int numberOfCountries = addresses.Select(addr => addr.Country).Distinct().Count();

9. var companiesAndCustomers =customers.Select(c =>new { c.FirstName, c.LastName, c.CompanyName }).Join(addresses, custs =>custs.CompanyName, addrs => addrs.CompanyName, (custs, addrs) =>new {custs.FirstName, custs.LastName, addrs.Country });

10. a differed collection only stores the instuctions of how to gather the data while a static cached collection collects the data beforehand and stores it.
