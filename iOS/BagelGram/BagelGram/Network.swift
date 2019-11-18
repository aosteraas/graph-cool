//
//  Network.swift
//  BagelGram
//
//  Created by Aaron Osteraas on 19/11/19.
//  Copyright © 2019 Aaron Osteraas. All rights reserved.
//

import Foundation
import Apollo

class Network {
    static let shared = Network();
    
    private(set) lazy var apollo = ApolloClient(url: URL(string: "https://localhost:5001/graphql")!)
}
