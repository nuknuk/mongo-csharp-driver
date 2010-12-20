﻿/* Copyright 2010 10gen Inc.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MongoDB.Bson.IO {
    public class BsonBinaryReaderBookmark : BsonReaderBookmark {
        #region private fields
        private BsonBinaryReaderContext context;
        private int position;
        #endregion

        #region constructors
        internal BsonBinaryReaderBookmark(
            BsonReadState state,
            BsonType currentBsonType,
            string currentName,
            BsonBinaryReaderContext context,
            int position
        )
            : base(state, currentBsonType, currentName) {
            this.context = context.Clone();
            this.position = position;
        }
        #endregion

        #region internal properties
        internal BsonBinaryReaderContext Context {
            get { return context; }
        }

        internal int Position {
            get { return position; }
        }
        #endregion
    }
}
