class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        freq = {}

        for num in nums:
            freq[num] = 1 + freq.get(num, 0)

        sortedPair = sorted(freq.items(), key=lambda pair: pair[1], reverse = True)

        return [pair[0] for pair in sortedPair[:k]]