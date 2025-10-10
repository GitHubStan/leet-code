# Algorithm Reference Guide

A comprehensive reference for common algorithm patterns and techniques used in LeetCode problems.

---

## Greedy Algorithms

### Characteristics

**Definition:** A greedy algorithm makes the locally optimal choice at each step with the hope of finding a global optimum.

**Key Characteristics:**

1. **Local Optimization:** Makes the best choice at each step without reconsidering previous choices
2. **No Backtracking:** Once a decision is made, it's never reconsidered or undone
3. **Greedy Choice Property:** A global optimum can be arrived at by selecting local optimum
4. **Optimal Substructure:** An optimal solution contains optimal solutions to subproblems
5. **Irrevocable Decisions:** Choices are made based on current information without regard to future consequences

### When to Use Greedy

- The problem exhibits both greedy choice property and optimal substructure
- Making a locally optimal choice leads to a globally optimal solution
- The problem asks for maximum/minimum of something
- You can prove that the greedy approach works (often mathematically)

### Common Greedy Patterns

1. **Activity Selection / Interval Scheduling**
   - Sort by end time
   - Select activities that don't overlap
   - Examples: Meeting Rooms, Non-overlapping Intervals

2. **Fractional Knapsack**
   - Sort by value-to-weight ratio
   - Take items with highest ratio first

3. **Huffman Coding / Merge Operations**
   - Always merge the two smallest elements
   - Build optimal tree from bottom up

4. **Gas Station / Jump Game**
   - Track running total/balance
   - Make decisions based on feasibility at each step

5. **Two-Pointer Greedy**
   - Use two pointers with greedy strategy
   - Examples: Container With Most Water, Trapping Rain Water

### How to Identify Greedy Problems

**Keywords/Phrases:**
- "Maximum" or "Minimum"
- "Optimal"
- "At least" or "At most"
- "Largest" or "Smallest"
- Problems involving scheduling, intervals, or selections

**Problem Types:**
- Interval scheduling problems
- Minimum number of operations
- Maximum profit/value problems
- Activity selection problems
- Problems where sorting helps

### Advantages

- Usually simple and intuitive
- Often more efficient than dynamic programming (O(n) or O(n log n))
- Easy to implement
- Uses less memory than DP

### Disadvantages

- Doesn't always produce optimal solution
- Can be difficult to prove correctness
- May need counterexamples to verify it works
- Not suitable when future choices depend on current choices in complex ways

### Greedy vs Dynamic Programming

**Use Greedy when:**
- Local optimal choices lead to global optimum
- No need to explore all possibilities
- Can prove greedy choice property

**Use DP when:**
- Greedy doesn't work (need counterexample)
- Overlapping subproblems exist
- Need to consider all possibilities
- Optimal substructure with multiple options at each step

### Common LeetCode Problems

**Easy:**
- 455: Assign Cookies
- 860: Lemonade Change
- 1005: Maximize Sum Of Array After K Negations

**Medium:**
- 134: Gas Station
- 55: Jump Game
- 45: Jump Game II
- 435: Non-overlapping Intervals
- 452: Minimum Number of Arrows to Burst Balloons
- 406: Queue Reconstruction by Height
- 621: Task Scheduler

**Hard:**
- 135: Candy
- 316: Remove Duplicate Letters
- 402: Remove K Digits

### Tips for Solving Greedy Problems

1. **Sort first:** Many greedy problems become easier after sorting
2. **Prove correctness:** Try to find a counterexample; if you can't, the greedy approach likely works
3. **Look for patterns:** Identify which greedy pattern applies
4. **Simulate:** Walk through examples to verify the approach
5. **Check edge cases:** Single element, all same elements, already optimal, etc.

### Example: Gas Station Problem

**Problem:** Find starting gas station to complete circular route

**Greedy Insight:**
- If total gas < total cost, impossible
- If we can't reach station j from station i, then any station between i and j also can't reach j
- Start from the next station after failure point

**Why Greedy Works:**
- If we fail at position j starting from i, the cumulative gas was negative
- Any intermediate station would have less accumulated gas, so would also fail
- Therefore, we can skip all intermediate stations (greedy choice)

---

