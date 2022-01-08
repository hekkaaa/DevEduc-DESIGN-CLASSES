using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESIGN_CLASSES.Collection
{
    internal class MyList<T> : IList<T>
    {
        private int _capacity = 0;
        private int _count = 0;
        private T[] _massive = new T[0];

        // Конструкторы
        public MyList() { }
        public MyList(int value)
        {   
            if(value < 0) { throw new ArgumentOutOfRangeException("value"); }
            else { this._capacity = value; this._massive = new T[value]; }
        }
        public MyList(IEnumerable<T> value)
        {   
            // пока пропущен
            if(value == null) { throw new ArgumentNullException("value"); }
        }
        
        // Свойства
        public T this[int index]
        {
            get
            {
                if (index < 0) { throw new IndexOutOfRangeException(); }
                if(index > _count-1) { throw new ArgumentOutOfRangeException(); }
                return _massive[index];
            }

            set 
            {
                if( index > _count || index < 0) { throw new ArgumentOutOfRangeException(); }
                _massive[index] = value; 
            
            }
        }
        public int Count { get { return _count; } } // Свойство для подсчета длинны MyList
        public int Capacity { get { return _capacity; } }

        // Методы
        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {   
            if(_capacity == 0)
            {
                _massive = new T[4];
                _capacity = _massive.Length;
            }
            if (_count + 1 > _capacity)
            {
                _capacity = _capacity * 2;
                
                T[] tmp = new T[_massive.Length];
                Array.Copy(this._massive, tmp, this._massive.Length);

                _massive = new T[_capacity];
                Array.Copy(tmp, _massive, tmp.Length);
            }
            _massive[_count++] = item;
        }

        public void Clear()
        {
            _count = 0;
            Array.Clear(_massive, 0, _massive.Length);
        }

        public bool Contains(T item)
        {
            foreach(T item2 in _massive)
            {
                if(item2 == null) continue;
                if(item2.Equals(item) == true) return true;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {   
            foreach (T item in _massive)
            {
                try
                {   
                    if(item == null) break;
                    array[arrayIndex] = item;
                    arrayIndex++;
                }
                catch (ArgumentException ex)
                {
                    throw new ArgumentException(ex.Message);
                }
                catch(IndexOutOfRangeException ex)
                {
                    throw new IndexOutOfRangeException(ex.Message);
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return (IEnumerator<T>)this;
        }

        public int IndexOf(T item)
        {   
            int count = 0;
            foreach (T item2 in _massive)
            {
                if (item2 == null) continue;
                if (item2.Equals(item) == true) return count;
                count++;
            }
            return -1;
        }

        public void Insert(int index, T item)
        {
            if(index > _count || item == null || index < 0) throw new ArgumentNullException();

            _massive[index] = item;
        }

        public bool Remove(T item)
        {
            int i = 0;
            bool flag = false;
            T[] tmp = new T[_massive.Length];

            foreach (T item2 in _massive)
            {
                if (item2 == null) continue;
                if (item2.Equals(item) == false)
                {
                    tmp[i] = item2;
                    i++;
                }
                else if (item2.Equals(item) == true && flag == false)
                {
                    flag = true;
                    _count--;
                }
                else
                {
                    tmp[i] = item2;
                    i++;
                }
            }
            
            tmp.CopyTo(_massive, 0);
            if(flag == true) return true;
            else return false;
        }

        public void RemoveAt(int index)
        {
            int i = 0;
            T[] tmp = new T[_massive.Length];
            foreach(T item2 in _massive)
            {
                if(i == index) { _count--; index = -1; }  // просто убираем индекс
                else { tmp[i] = item2; i++; }
            }
            tmp.CopyTo(_massive, 0);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
    }
}
