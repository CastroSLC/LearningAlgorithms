namespace LearningAlgorithms.Algoritmos.Advanced {
    /*
        You are given a list of airline tickets where tickets[i] = [fromi, toi] represent the departure and the arrival airports of one flight. 
        Reconstruct the itinerary in order and return it.

        All of the tickets belong to a man who departs from "JFK", thus, the itinerary must begin with "JFK". 
        If there are multiple valid itineraries, you should return the itinerary that has the smallest lexical order when read as a single string.

        For example, the itinerary ["JFK", "LGA"] has a smaller lexical order than ["JFK", "LGB"].
        You may assume all tickets form at least one valid itinerary. You must use all the tickets once and only once

        Input: tickets = [["MUC","LHR"],["JFK","MUC"],["SFO","SJC"],["LHR","SFO"]]
        Output: ["JFK","MUC","LHR","SFO","SJC"]
    */
    public static class Itinerary {

        static Dictionary<string, string> itinerario = new Dictionary<string, string>(){
            { "MUC", "LHR" },
            { "JFK", "MUC" },
            { "SFO", "SJC" },
            { "LHR", "SFO" }
        };

        static void GetItinerario(IList<IList<string>> tickets) {
            var sortedTickets = tickets.OrderBy(ticket => ticket[1]).ToList();
            var adjacencyList = new Dictionary<string, List<string>>();

            foreach(var ticket in sortedTickets) {
                if(!adjacencyList.ContainsKey(ticket[0])) {
                    adjacencyList[ticket[0]] = new List<string>();
                }

                adjacencyList[ticket[0]].Add(ticket[1]);
                // Ejemplo: imprimir todos los tickets
                foreach(var t in adjacencyList) {
                    Console.WriteLine($"{t.Key} -> {t.Value}");
                }

            }

            Console.WriteLine(String.Join(',', adjacencyList));
        }
    }
}
