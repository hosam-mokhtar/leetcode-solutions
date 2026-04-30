Link: https://leetcode.com/problems/implement-trie-prefix-tree/
Language: C#







    public class TrieNode
    {
        public TrieNode[] children = new TrieNode[26];
        public bool isEnd = false;
    }
    public class Trie
    {
        private TrieNode root = new();

        public void Insert(string word)
        {
            var node = root;

            foreach (var ch in word)
            {
                if (node.children[ch - 'a'] == null)
                    node.children[ch - 'a'] = new TrieNode();
                node = node.children[ch - 'a'];
            }

            node.isEnd = true;
        }

        public bool Search(string word)
        {
            var node = root;

            foreach (var ch in word)
            {
                if (node.children[ch - 'a'] == null)
                    return false;
                node = node.children[ch - 'a'];
            }

            return node.isEnd;
        }

        public bool StartsWith(string prefix)
        {
            var node = root;

            foreach (var ch in prefix)
            {
                if (node.children[ch - 'a'] == null)
                    return false;
                node = node.children[ch - 'a'];
            }
            return true;
        }
    }

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */