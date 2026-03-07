namespace LeetCodeNet.G0101_0200.S0146_lru_cache {

// #Medium #Top_100_Liked_Questions #Top_Interview_Questions #Hash_Table #Design #Linked_List
// #Doubly_Linked_List #Udemy_Linked_List #Top_Interview_150_Linked_List
// #Big_O_Time_O(1)_Space_O(capacity) #2025_06_14_Time_28_ms_(80.36%)_Space_174.73_MB_(41.35%)

public class LRUCache { //NOSONAR
    private readonly int capacity;
    private readonly Dictionary<int, LinkedListNode<CacheItem>> cacheMap;
    private readonly LinkedList<CacheItem> cacheList;

    public LRUCache(int capacity) {
        this.capacity = capacity;
        cacheMap = new Dictionary<int, LinkedListNode<CacheItem>>(capacity);
        cacheList = new LinkedList<CacheItem>();
    }
    
    public int Get(int key) {
        if (cacheMap.TryGetValue(key, out var node)) {
            cacheList.Remove(node);
            cacheList.AddFirst(node);
            return node.Value.Value;
        }
        return -1;
    }
    
    public void Put(int key, int value) {
        if (cacheMap.TryGetValue(key, out var node)) {
            node.Value.Value = value;
            cacheList.Remove(node);
            cacheList.AddFirst(node);
        } else {
            if (cacheMap.Count >= capacity) {
                var lastNode = cacheList.Last;
                cacheMap.Remove(lastNode!.Value.Key);
                cacheList.RemoveLast();
            }
            var newNode = new LinkedListNode<CacheItem>(new CacheItem(key, value));
            cacheMap.Add(key, newNode);
            cacheList.AddFirst(newNode);
        }
    }

    private sealed class CacheItem {
        public int Key { get; }
        public int Value { get; set; }

        public CacheItem(int key, int value) {
            Key = key;
            Value = value;
        }
    }
}

public class KeyNode {

    public int key { get; set; }

    public int val { get; set; }

    public KeyNode next { get; set; }

    public KeyNode() {
        key = int.MinValue;
        val = int.MinValue;
        next = null!;
    }

    public KeyNode(int key, int val): this() {
        this.key = key;
        this.val = val;
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */
}
