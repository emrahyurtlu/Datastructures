﻿namespace Tree.BinaryTree;

public interface IBinaryTree<T>
{
    T AddLeft(T value);
    T AddRight(T value);

    void Remove(T value);

    BinaryNode<T> DepthFirstSearch(T value);

    int Height();

    int Level();

    int Size();

    bool IsLeaf();

    int NumberOfLeaves();

    bool Contains(T value);
    
    BinaryNode<T> GetRoot();
}