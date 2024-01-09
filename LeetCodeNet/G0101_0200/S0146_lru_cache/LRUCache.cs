namespace LeetCodeNet.G0101_0200.S0146_lru_cache {

// #Medium #Top_100_Liked_Questions #Top_Interview_Questions #Hash_Table #Design #Linked_List
// #Doubly_Linked_List #Udemy_Linked_List #Big_O_Time_O(1)_Space_O(capacity)
// #2024_01_09_Time_780_ms_(34.57%)_Space_239.2_MB_(12.44%)

public class LRUCache {
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
                cacheMap.Remove(lastNode.Value.Key);
                cacheList.RemoveLast();
            }
            var newNode = new LinkedListNode<CacheItem>(new CacheItem(key, value));
            cacheMap.Add(key, newNode);
            cacheList.AddFirst(newNode);
        }
    }

    private class CacheItem {
        public int Key { get; }
        public int Value { get; set; }

        public CacheItem(int key, int value) {
            Key = key;
            Value = value;
        }
    }
}

public class KeyNode {
    private int _key;
    private int _val;
    private KeyNode _next;

    public int key { 
        get { return _key; }
        set { _key = value; } 
    }

    public int val {
        get { return _val; }
        set { _val = value; }
    }

    public KeyNode next {
        get { return _next; }
        set { _next = value; }
    }

    public KeyNode() {
        _key = int.MinValue;
        _val = int.MinValue;
        _next = null;
    }

    public KeyNode(int key, int val): this() {
        _key = key;
        _val = val;
    }
}

/*
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */
}
